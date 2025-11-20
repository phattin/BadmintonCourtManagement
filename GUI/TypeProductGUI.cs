using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class TypeProductGUI : UserControl
    {
        private AccountDTO? currentAccount;
        private TypeProductBUS typeProductBUS;

        // Biến phân trang
        private int page = 0;
        private const int itemPerPage = 8; // 2 hàng x 4 cột = 8 loại/trang
        private int totalPages = 0;
        private List<TypeProductDTO> currentTypeProductList = new List<TypeProductDTO>();

        public TypeProductGUI()
        {
            InitializeComponent();
            typeProductBUS = new TypeProductBUS();
        }

        public TypeProductGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            typeProductBUS = new TypeProductBUS();
            LoadTypeProducts(typeProductBUS.GetAllTypeProducts());
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
            if (pCustomerList == null)
                return;

            currentTypeProductList = list ?? new List<TypeProductDTO>();
            totalPages = (int)Math.Ceiling((double)currentTypeProductList.Count / itemPerPage);
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
            int endIndex = Math.Min(startIndex + itemPerPage, currentTypeProductList.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                var item = currentTypeProductList[i];
                var panel = CreateTypeProductPanel(item);
                int row = (i - startIndex) / 4;
                int col = (i - startIndex) % 4;
                pCustomerList.Controls.Add(panel, col, row);
            }

            // Safely position pagination panel inside customPanel1 (if available)
            if (paginationPanel != null && customPanel1 != null)
            {
                int y = Math.Max(0, customPanel1.Height - paginationPanel.Height);
                paginationPanel.Location = new Point(0, y);
                paginationPanel.Width = Math.Max(0, customPanel1.Width);
            }

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
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3
            };
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 33F)); // Mã loại
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 33F)); // Tên loại
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 34F)); // Nút

            var lblId = new Label
            {
                Text = dto.TypeProductId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblName = new Label
            {
                Text = dto.TypeProductName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 12, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter,
                ForeColor = Color.FromArgb(0, 100, 80)
            };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Padding = new Padding(0, 5, 0, 5),
                Anchor = AnchorStyles.None
            };

            var btnDelete = new Button
            {
                Text = "Xóa",
                Width = 70,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            var btnEdit = new Button
            {
                Text = "Sửa",
                Width = 70,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            btnDelete.Click += (s, ev) =>
            {
                var result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa loại sản phẩm '{dto.TypeProductName}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool deleted = typeProductBUS.DeleteTypeProduct(dto.TypeProductId);
                        if (deleted)
                        {
                            MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadTypeProductList();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa (có thể đang được sử dụng trong sản phẩm).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            // Trong btnEdit.Click
            var form = new FormTypeProduct("Update", dto.TypeProductId, currentAccount);
            form.ShowDialog();
            ReloadTypeProductList();
            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            tl.Controls.Add(lblId, 0, 0);
            tl.Controls.Add(lblName, 0, 1);
            tl.Controls.Add(buttonPanel, 0, 2);

            panel.Controls.Add(tl);
            return panel;
        }

        private void UpdatePaginationInfo()
        {
            int totalWidth = 400;
            int startX = (paginationPanel.Width - totalWidth) / 2;

            btnExtraPrevious.Location = new Point(startX, 13);
            btnPrevious.Location = new Point(startX + 70, 13);
            lblPageInfo.Location = new Point(startX + 140, 28);
            btnNext.Location = new Point(startX + 260, 13);
            btnExtraNext.Location = new Point(startX + 330, 13);

            btnExtraPrevious.Enabled = page > 0;
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page < totalPages - 1;
            btnExtraNext.Enabled = page < totalPages - 1;

            lblPageInfo.Text = $"Trang {page + 1} / {totalPages}";
        }

        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadTypeProducts(currentTypeProductList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) page--; LoadTypeProducts(currentTypeProductList); }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) page++; LoadTypeProducts(currentTypeProductList); }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = totalPages - 1; LoadTypeProducts(currentTypeProductList); }
        private void TypeProducrGUI_Load(object sender, EventArgs e)
        {

        }
    }
}