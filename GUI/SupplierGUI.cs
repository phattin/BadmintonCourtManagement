
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class SupplierGUI : UserControl
    {
        private AccountDTO? currentAccount;
        private SupplierBUS supplierBUS;

        private int page = 0;
        private const int itemPerPage = 8;
        private int totalPages = 0;
        private List<SupplierDTO> currentSupplierList = new List<SupplierDTO>();
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;

        public SupplierGUI()
        {
            InitializeComponent();
            supplierBUS = new SupplierBUS();
        }

        public SupplierGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            CheckPermissions("F07");
            supplierBUS = new SupplierBUS();
            LoadSuppliers(supplierBUS.GetAllSuppliers());
        }

        private void CheckPermissions(string functionId)
        {
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId(functionId);

            foreach (var p in permissionDetails)
            {
                if (p.PermissionId == currentAccount.PermissionId)
                {
                    if (p.Option == "Insert") isInsert = true;
                    else if (p.Option == "Update") isUpdate = true;
                    else if (p.Option == "Delete") isDelete = true;
                }
            }

            lblAddSupplier.Visible = isInsert;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            page = 0;
            if (string.IsNullOrEmpty(searchText))
                LoadSuppliers(supplierBUS.GetAllSuppliers());
            else
                LoadSuppliers(supplierBUS.Search(searchText));
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            page = 0;
            LoadSuppliers(supplierBUS.GetAllSuppliers());
        }

        private void lblAddSupplier_Click(object sender, EventArgs e)
        {
            var form = new FormSupplierGUI("Insert", null, currentAccount);
            form.ShowDialog();
            ReloadSupplierList();
        }

        private void LoadSuppliers(List<SupplierDTO> list)
        {
            if (pCustomerList == null) return;

            currentSupplierList = list ?? new List<SupplierDTO>();
            totalPages = (int)Math.Ceiling((double)currentSupplierList.Count / itemPerPage);
            if (totalPages == 0) totalPages = 1;
            if (page >= totalPages) page = totalPages - 1;
            if (page < 0) page = 0;

            pCustomerList.Controls.Clear();
            pCustomerList.RowCount = 2;
            pCustomerList.ColumnCount = 4;
            pCustomerList.ColumnStyles.Clear();
            pCustomerList.RowStyles.Clear();
            for (int i = 0; i < 4; i++)
                pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int startIndex = page * itemPerPage;
            int endIndex = Math.Min(startIndex + itemPerPage, currentSupplierList.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                var panel = CreateSupplierPanel(currentSupplierList[i]);
                int row = (i - startIndex) / 4;
                int col = (i - startIndex) % 4;
                pCustomerList.Controls.Add(panel, col, row);
            }

            // Đặt lại vị trí pagination panel
            if (paginationPanel != null && customPanel1 != null)
            {
                int y = Math.Max(0, customPanel1.Height - paginationPanel.Height);
                paginationPanel.Location = new Point(0, y);
                paginationPanel.Width = customPanel1.Width;
            }

            UpdatePaginationInfo();
        }

        private void ReloadSupplierList()
        {
            page = 0;
            LoadSuppliers(supplierBUS.GetAllSuppliers());
        }

        private CustomPanel CreateSupplierPanel(SupplierDTO dto)
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
                RowCount = 4
            };
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            var lblId = new Label { Text = dto.SupplierId, Dock = DockStyle.Fill, Font = new Font("Segoe UI", 14, FontStyle.Bold), TextAlign = ContentAlignment.MiddleCenter };
            var lblName = new Label { Text = dto.SupplierName, Dock = DockStyle.Fill, Font = new Font("Segoe UI", 12), TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.FromArgb(0, 100, 80) };
            var lblContact = new Label { Text = $"{dto.SupplierAddress} - {dto.SupplierEmail}".Trim(' ', '-'), Dock = DockStyle.Fill, Font = new Font("Segoe UI", 11, FontStyle.Italic), TextAlign = ContentAlignment.MiddleCenter, ForeColor = Color.FromArgb(0, 100, 80) };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0, 5, 0, 5),
                Anchor = AnchorStyles.None
            };

            var btnDelete = new Button { Text = "Xóa", Width = 70, Height = 35, BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat, Margin = new Padding(10, 0, 10, 0) };
            btnDelete.Visible = isDelete;
            var btnEdit = new Button { Text = "Sửa", Width = 70, Height = 35, BackColor = Color.FromArgb(64, 64, 64), ForeColor = Color.White, Font = new Font("Segoe UI", 10, FontStyle.Bold), FlatStyle = FlatStyle.Flat, Margin = new Padding(10, 0, 10, 0) };
            btnEdit.Visible = isUpdate;

            btnDelete.Click += (s, ev) =>
            {
                if (MessageBox.Show($"Bạn có chắc muốn xóa nhà cung cấp '{dto.SupplierName}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        if (supplierBUS.DeleteSupplier(dto.SupplierId))
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadSupplierList();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa (có thể đang được sử dụng).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            btnEdit.Click += (s, ev) =>
            {
                var form = new FormSupplierGUI("Update", dto.SupplierId, currentAccount);
                form.ShowDialog();
                ReloadSupplierList();
            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            tl.Controls.Add(lblId, 0, 0);
            tl.Controls.Add(lblName, 0, 1);
            tl.Controls.Add(lblContact, 0, 2);
            tl.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tl);
            return panel;
        }

        private void UpdatePaginationInfo()
        {
            // Center only the four navigation buttons (no page number label)
            int totalWidth = 280; // 4 buttons (60px) + spacing
            int startX = Math.Max(0, (paginationPanel.Width - totalWidth) / 2);

            btnExtraPrevious.Location = new Point(startX, 13);
            btnPrevious.Location = new Point(startX + 70, 13);
            btnNext.Location = new Point(startX + 140, 13);
            btnExtraNext.Location = new Point(startX + 210, 13);

            btnExtraPrevious.Enabled = page > 0;
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page < totalPages - 1;
            btnExtraNext.Enabled = page < totalPages - 1;
        }

        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadSuppliers(currentSupplierList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) page--; LoadSuppliers(currentSupplierList); }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) page++; LoadSuppliers(currentSupplierList); }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = totalPages - 1; LoadSuppliers(currentSupplierList); }

        private void SupplierGUI_Load(object sender, EventArgs e) { }
    }
}