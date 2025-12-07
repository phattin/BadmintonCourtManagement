using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class TypeProductGUI : UserControl
    {
        private AccountDTO currentAccount;
        private TypeProductBUS typeProductBUS;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;

        // Phân trang
        private int page = 0;
        private const int itemPerPage = 8;
        private int totalPages = 0;
        private List<TypeProductDTO> currentTypeProductList;

        public TypeProductGUI()
        {
            InitializeComponent();
        }

        public TypeProductGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            CheckPermissions("F09"); // Thay "F09" bằng mã chức năng thực tế của bạn
            typeProductBUS = new TypeProductBUS();
            LoadTypeProducts(typeProductBUS.GetAllTypeProducts());
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

            lblAddTypeProduct.Visible = isInsert;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            page = 0;
            if (string.IsNullOrEmpty(searchText))
            {
                LoadTypeProducts(typeProductBUS.GetAllTypeProducts());
            }
            else
            {
                 LoadTypeProducts(typeProductBUS.GetByTypeName(searchText));
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Text = string.Empty;
            page = 0;
            LoadTypeProducts(typeProductBUS.GetAllTypeProducts());
        }

        private void lblAddTypeProduct_Click(object sender, EventArgs e)
        {
            Form dialog = new Form()
            {
                Text = string.Empty,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(450, 350),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var formTypeProduct = new FormTypeProduct("Insert", null, currentAccount);
            formTypeProduct.ShowDialog();
            ReloadTypeProductList();
        }

        private void LoadTypeProducts(List<TypeProductDTO> list)
        {
            currentTypeProductList = list ?? new List<TypeProductDTO>();
            totalPages = (int)Math.Ceiling((double)currentTypeProductList.Count / itemPerPage);
            if (totalPages == 0) totalPages = 1;
            if (page >= totalPages) page = totalPages - 1;
            if (page < 0) page = 0;

            pTypeProductList.Controls.Clear();
            pTypeProductList.RowCount = 2;
            pTypeProductList.ColumnCount = 4;

            pTypeProductList.ColumnStyles.Clear();
            pTypeProductList.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                pTypeProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pTypeProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int startIndex = page * itemPerPage;
            int endIndex = Math.Min(startIndex + itemPerPage, currentTypeProductList.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                var item = currentTypeProductList[i];
                var panel = CreateTypeProductPanel(item);
                int row = (i - startIndex) / 4;
                int col = (i - startIndex) % 4;
                pTypeProductList.Controls.Add(panel, col, row);
            }

            paginationPanel.Location = new Point(0, customPanel1.Height - paginationPanel.Height);
            paginationPanel.Width = customPanel1.Width;

            UpdatePaginationInfo();
        }

        private void ReloadTypeProductList()
        {
            page = 0;
            LoadTypeProducts(typeProductBUS.GetAllTypeProducts());
        }

        private CustomPanel CreateTypeProductPanel(TypeProductDTO dto)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 250, 214),
                Margin = new Padding(8),
                Dock = DockStyle.Fill
            };

            var tl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4,
                Padding = new Padding(10)
            };

            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Mã
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Tên
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 15F)); // Placeholder
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 25F)); // Nút

            var lblId = new Label
            {
                Text = dto.TypeProductId,
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var lblName = new Label
            {
                Text = "Tên: " + dto.TypeProductName,
                Font = new Font("Segoe UI", 11F),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Padding = new Padding(0, 5, 0, 5)
            };

            var btnDelete = new Button
            {
                Text = "Xóa",
                Size = new Size(70, 35),
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };
            btnDelete.Visible = isDelete;

            var btnEdit = new Button
            {
                Text = "Sửa",
                Size = new Size(70, 35),
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };
            btnEdit.Visible = isUpdate;

            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show($"Xóa loại sản phẩm '{dto.TypeProductName}'?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    if (typeProductBUS.DeleteTypeProduct(dto.TypeProductId))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ReloadTypeProductList();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa (đang được sử dụng hoặc lỗi CSDL).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            btnEdit.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(450, 350),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var form = new FormTypeProduct("Update", dto.TypeProductId, currentAccount);

                form.ShowDialog();
                ReloadTypeProductList();

            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            tl.Controls.Add(lblId, 0, 0);
            tl.Controls.Add(lblName, 0, 1);
            tl.Controls.Add(new Label(), 0, 2); // placeholder
            tl.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tl);
            return panel;
        }

        private void UpdatePaginationInfo()
        {
            int totalWidth = 400;
            int startX = (paginationPanel.Width - totalWidth) / 2;

            btnExtraPrevious.Location = new Point(startX, 13);
            btnPrevious.Location = new Point(startX + 70, 13);
            btnNext.Location = new Point(startX + 260, 13);
            btnExtraNext.Location = new Point(startX + 330, 13);

            btnExtraPrevious.Enabled = page > 0;
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page < totalPages - 1;
            btnExtraNext.Enabled = page < totalPages - 1;
        }

        // Các nút phân trang
        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadTypeProducts(currentTypeProductList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) page--; LoadTypeProducts(currentTypeProductList); }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) page++; LoadTypeProducts(currentTypeProductList); }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = totalPages - 1; LoadTypeProducts(currentTypeProductList); }

        private void paginationPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}