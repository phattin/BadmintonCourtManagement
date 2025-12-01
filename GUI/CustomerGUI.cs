using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class CustomerGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CustomerBUS customerBUS;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;

        // Biến phân trang
        private int page = 0;
        private const int itemPerPage = 8; // 2 hàng x 4 cột = 8 khách hàng/trang
        private int totalPages = 0;
        private List<CustomerDTO> currentCustomerList; // Danh sách hiện tại (tìm kiếm hoặc tất cả)

        public CustomerGUI()
        {
            InitializeComponent();
        }

        public CustomerGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            CheckPermissions("F08");
            customerBUS = new CustomerBUS();
            LoadCustomers(customerBUS.GetAllCustomers());
            
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

            lblAddCustomer.Visible = isInsert;
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            page = 0; // Reset trang khi tìm kiếm
            if (string.IsNullOrEmpty(searchText))
            {
                LoadCustomers(customerBUS.GetAllCustomers());
            }
            else
            {
                LoadCustomers(customerBUS.Search(searchText));
            }
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
           txtSearch.Text = string.Empty;
            page = 0;
            LoadCustomers(customerBUS.GetAllCustomers());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Optional: Could trigger search manually, but TextChanged handles it
        }

        private void lblAddCustomer_Click(object sender, EventArgs e)
        {
            Form dialog = new Form()
            {
                Text = string.Empty,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(450, 450),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var addCustomerGUI = new FormCustomerGUI("Insert", customerBUS.GetNextId(), currentAccount);
            addCustomerGUI.Dock = DockStyle.Fill;
            dialog.Controls.Add(addCustomerGUI);
            dialog.ShowDialog();
            ReloadCustomerList();
        }

        private void LoadCustomers(List<CustomerDTO> danhSachKhachHang)
        {
            currentCustomerList = danhSachKhachHang ?? new List<CustomerDTO>();
            totalPages = (int)Math.Ceiling((double)currentCustomerList.Count / itemPerPage);
            if (totalPages == 0) totalPages = 1;
            if (page >= totalPages) page = totalPages - 1;
            if (page < 0) page = 0;

            pCustomerList.Controls.Clear();
            pCustomerList.RowCount = 2; // Luôn 2 hàng
            pCustomerList.ColumnCount = 4;
            pCustomerList.Height = customPanel1.Height - paginationPanel.Height - customPanel2.Height - 40; // Adjust height to account for pagination

            // Xóa style cũ
            pCustomerList.ColumnStyles.Clear();
            pCustomerList.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            for (int j = 0; j < 2; j++)
                pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int startIndex = page * itemPerPage;
            int endIndex = Math.Min(startIndex + itemPerPage, currentCustomerList.Count);

            for (int i = startIndex; i < endIndex; i++)
            {
                var customerDTO = currentCustomerList[i];
                var panel = CreateCustomerPanel(customerDTO);
                int row = (i - startIndex) / 4;
                int col = (i - startIndex) % 4;
                pCustomerList.Controls.Add(panel, col, row);
            }

            // Position pagination panel
            paginationPanel.Location = new Point(0, customPanel1.Height - paginationPanel.Height);
            paginationPanel.Width = customPanel1.Width;
            
            // Cập nhật phân trang
            UpdatePaginationInfo();
        }

        private void ReloadCustomerList()
        {
            page = 0; // Reset về trang đầu
            LoadCustomers(customerBUS.GetAllCustomers());
        }

        private CustomPanel CreateCustomerPanel(CustomerDTO customerDTO)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 250, 214),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tlCustomer = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4
            };

            tlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Mã khách hàng
            tlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Tên khách hàng
            tlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Số điện thoại
            tlCustomer.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Nút

            // Label mã khách hàng
            var lblID = new Label
            {
                Text = customerDTO.CustomerId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Label tên khách hàng
            var lblName = new Label
            {
                Text = "Tên: " + customerDTO.CustomerName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Label số điện thoại (assuming Phone exists; adjust if different)
            var lblPhone = new Label
            {
                Text = "SĐT: " + (customerDTO.CustomerPhone ?? "N/A"),
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Panel chứa hai nút
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Padding = new Padding(0, 5, 0, 5),
                Margin = new Padding(0),
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // Nút Xóa
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
            btnDelete.Visible = isDelete;

            // Nút Sửa
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
            btnEdit.Visible = isUpdate;

            // Sự kiện Xóa
            btnDelete.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa khách hàng '{customerDTO.CustomerName}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = customerBUS.DeleteCustomer(customerDTO.CustomerId);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa khách hàng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadCustomerList(); // Cập nhật lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa khách hàng này (có thể đang có đặt sân hoặc lỗi cơ sở dữ liệu).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa khách hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            // Sự kiện Sửa
            btnEdit.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty, // bỏ tiêu đề
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(450, 450),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var editCustomerGUI = new FormCustomerGUI("Update", customerDTO.CustomerId, currentAccount);
                editCustomerGUI.Dock = DockStyle.Fill;

                dialog.Controls.Add(editCustomerGUI);

                dialog.ShowDialog();

                ReloadCustomerList(); // reload danh sách sau khi đóng dialog
            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            // Thêm tất cả control vào TableLayoutPanel
            tlCustomer.Controls.Add(lblID, 0, 0);
            tlCustomer.Controls.Add(lblName, 0, 1);
            tlCustomer.Controls.Add(lblPhone, 0, 2);
            tlCustomer.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tlCustomer);

            return panel;
        }

        private void UpdatePaginationInfo()
        {
            // lblPageInfo.Text = $"Trang {page + 1} / {totalPages}";

            // Center the pagination controls
            int totalWidth = 400; // Total width of all controls
            int startX = (paginationPanel.Width - totalWidth) / 2;
            
            btnExtraPrevious.Location = new Point(startX, 13);
            btnPrevious.Location = new Point(startX + 70, 13);
            lblPageInfo.Location = new Point(startX + 140, 28);
            btnNext.Location = new Point(startX + 260, 13);
            btnExtraNext.Location = new Point(startX + 330, 13);

            // Update button states
            btnExtraPrevious.Enabled = page > 0;
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page < totalPages - 1;
            btnExtraNext.Enabled = page < totalPages - 1;
        }

        private void btnExtraPrevious_Click(object sender, EventArgs e)
        {
            if (page != 0)
            {
                page = 0;
                LoadCustomers(currentCustomerList);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (page > 0)
            {
                page--;
                LoadCustomers(currentCustomerList);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (page < totalPages - 1)
            {
                page++;
                LoadCustomers(currentCustomerList);
            }
        }

        private void btnExtraNext_Click(object sender, EventArgs e)
        {
            if (page != totalPages - 1)
            {
                page = totalPages - 1;
                LoadCustomers(currentCustomerList);
            }
        }

        
    }
}