using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class CustomerGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CustomerBUS customerBUS;

        public CustomerGUI()
        {
            InitializeComponent();
        }

        public CustomerGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            customerBUS = new CustomerBUS();
            LoadCustomers(customerBUS.GetAllCustomers());
        }

        private void CustomerGUI_Load(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
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

            // var addCustomerGUI = new AddCustomerGUI();
            // addCustomerGUI.Dock = DockStyle.Fill;
            // dialog.Controls.Add(addCustomerGUI);
            dialog.ShowDialog();
            ReloadCustomerList();
        }

        private void LoadCustomers(List<CustomerDTO> danhSachKhachHang)
        {
            pCustomerList.Controls.Clear();
            pCustomerList.ColumnCount = 4;
            pCustomerList.RowCount = (int)Math.Ceiling(danhSachKhachHang.Count / 4.0);

            for (int i = 0; i < 4; i++)
                pCustomerList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));

            for (int j = 0; j < pCustomerList.RowCount; j++)
                pCustomerList.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / pCustomerList.RowCount));

            int index = 0;
            foreach (CustomerDTO customerDTO in danhSachKhachHang)
            {
                var panel = CreateCustomerPanel(customerDTO);
                int row = index / 4;
                int col = index % 4;
                pCustomerList.Controls.Add(panel, col, row);
                index++;
            }
        }

        private void ReloadCustomerList()
        {
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

                // var editCustomerGUI = new EditCustomerGUI(customerDTO);
                // editCustomerGUI.Dock = DockStyle.Fill;

                // dialog.Controls.Add(editCustomerGUI);

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
    }
}