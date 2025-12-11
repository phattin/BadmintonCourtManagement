using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class BrandGUI : UserControl
    {
        private AccountDTO? currentAccount;
        private BrandBUS brandBUS;

        private int page = 0;
        private const int itemPerPage = 8;
        private int totalPages = 0;
        private List<BrandDTO> currentBrandList = new List<BrandDTO>();
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;

        public BrandGUI()
        {
            InitializeComponent();
            brandBUS = new BrandBUS();
        }

        public BrandGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            CheckPermissions("F14");
            brandBUS = new BrandBUS();
            LoadBrands(brandBUS.GetAllBrands());
        }

        private void CheckPermissions(string functionId)
        {
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId(functionId);

            foreach (var p in permissionDetails)
            {
                if (p.PermissionId == currentAccount?.PermissionId)
                {
                    if (p.Option == "Insert") isInsert = true;
                    else if (p.Option == "Update") isUpdate = true;
                    else if (p.Option == "Delete") isDelete = true;
                }
            }

            lblAddBrand.Visible = isInsert;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            page = 0;
            if (string.IsNullOrEmpty(searchText))
                LoadBrands(brandBUS.GetAllBrands());
            else
                LoadBrands(brandBUS.Search(searchText));
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            page = 0;
            LoadBrands(brandBUS.GetAllBrands());
        }

        private void lblAddBrand_Click(object sender, EventArgs e)
        {
            var form = new FormBrandGUI("Insert", null, currentAccount);
            form.ShowDialog();
            ReloadBrandList();
        }

        private void LoadBrands(List<BrandDTO> list)
        {
            if (pBrandList == null) return;

            currentBrandList = list ?? new List<BrandDTO>();
            totalPages = (int)Math.Ceiling((double)currentBrandList.Count / itemPerPage);
            if (totalPages == 0) totalPages = 1;
            if (page >= totalPages) page = totalPages - 1;
            if (page < 0) page = 0;

            pBrandList.Controls.Clear();
            pBrandList.RowCount = 2;
            pBrandList.ColumnCount = 4;
            pBrandList.ColumnStyles.Clear();
            pBrandList.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
                pBrandList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pBrandList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int startIndex = page * itemPerPage;
            int endIndex = Math.Min(startIndex + itemPerPage, currentBrandList.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                int row = (i - startIndex) / 4;
                int col = (i - startIndex) % 4;
                var card = CreateBrandPanel(currentBrandList[i]);
                pBrandList.Controls.Add(card, col, row);
            }

            // Đặt lại vị trí pagination panel
            if (paginationPanel != null && customPanel1 != null)
            {
                int y = Math.Max(0, customPanel1.Height - paginationPanel.Height);
                paginationPanel.Location = new Point(0, y);
                paginationPanel.Width = customPanel1.Width;
                
                // Hide pagination if total items <= 8
                paginationPanel.Visible = currentBrandList.Count > itemPerPage;
            }

            UpdatePaginationInfo();
        }

        private void ReloadBrandList()
        {
            page = 0;
            LoadBrands(brandBUS.GetAllBrands());
        }

        private CustomPanel CreateBrandPanel(BrandDTO dto)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 250, 214),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3
            };
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F));

            var lblId = new Label { Text = dto.BrandId, Dock = DockStyle.Fill, Font = new Font("Segoe UI", 14, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter };
            var lblName = new Label { Text = dto.BrandName, Dock = DockStyle.Fill, Font = new Font("Segoe UI", 12), TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.FromArgb(0, 100, 80) };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0, 5, 0, 5),
                Anchor = AnchorStyles.None
            };

            var btnDelete = new Button { Text = "Xóa", Width = 60, Height = 30, BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold), FlatStyle = FlatStyle.Flat, Margin = new Padding(5, 0, 5, 0) };
            btnDelete.Visible = isDelete;
            var btnEdit = new Button { Text = "Sửa", Width = 60, Height = 30, BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, Font = new Font("Segoe UI", 9, FontStyle.Bold), FlatStyle = FlatStyle.Flat, Margin = new Padding(5, 0, 5, 0) };
            btnEdit.Visible = isUpdate;

            btnEdit.Click += (s, e) =>
            {
                var form = new FormBrandGUI("Update", dto.BrandId, currentAccount);
                form.ShowDialog();
                ReloadBrandList();
            };

            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show($"Bạn có chắc chắn muốn xóa thương hiệu '{dto.BrandName}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        if (brandBUS.DeleteBrand(dto.BrandId))
                        {
                            MessageBox.Show("Xóa thương hiệu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadBrandList();
                        }
                        else
                        {
                            MessageBox.Show("Xóa thương hiệu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            buttonPanel.Controls.Add(btnEdit);
            buttonPanel.Controls.Add(btnDelete);

            tl.Controls.Add(lblId, 0, 0);
            tl.Controls.Add(lblName, 0, 1);
            tl.Controls.Add(buttonPanel, 0, 2);
            panel.Controls.Add(tl);

            return panel;
        }

        private void UpdatePaginationInfo()
        {
            if (lblPageInfo != null)
            {
                int startItem = currentBrandList.Count == 0 ? 0 : (page * itemPerPage) + 1;
                int endItem = Math.Min((page + 1) * itemPerPage, currentBrandList.Count);
                lblPageInfo.Text = $"Trang {page + 1}/{totalPages} ({startItem}-{endItem} / {currentBrandList.Count})";
            }
        }

        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadBrands(currentBrandList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) { page--; LoadBrands(currentBrandList); } }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) { page++; LoadBrands(currentBrandList); } }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = totalPages - 1; LoadBrands(currentBrandList); }

        private void BrandGUI_Load(object sender, EventArgs e) { }
    }
}
