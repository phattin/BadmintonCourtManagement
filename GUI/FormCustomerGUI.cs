// FormCustomerGUI.cs (ĐÃ CẬP NHẬT - TỰ ĐỘNG TẠO ID)
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormCustomerGUI : UserControl
    {
        private string mode; // "Insert" hoặc "Update"
        private string customerId; // Chỉ dùng khi Update
        private CustomerBUS customerBUS = new CustomerBUS();

        public FormCustomerGUI(string mode, string customerId = null, AccountDTO currentAccount = null)
        {
            InitializeComponent();

            this.mode = mode;
            this.customerId = customerId; // Có thể null khi Insert

            // Tắt chỉnh sửa mã khách hàng
            txtCustomerId.Enabled = false;
            txtCustomerId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            if (mode == "Insert")
            {
                lblTitle.Text = "THÊM KHÁCH HÀNG";
                
                // TỰ ĐỘNG TẠO MÃ KHÁCH HÀNG MỚI
                string newId = GenerateNewCustomerId();
                txtCustomerId.Text = newId;
                this.customerId = newId; // Gán luôn để dùng khi lưu
            }
            else if (mode == "Update")
            {
                lblTitle.Text = "CẬP NHẬT THÔNG TIN";

                txtCustomerId.Text = customerId;

                var customer = customerBUS.GetCustomerById(customerId);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CustomerName;
                    txtCustomerPhone.Text = customer.CustomerPhone;
                }
            }
        }

        // HÀM TỰ ĐỘNG TẠO MÃ KHÁCH HÀNG MỚI (CUS0001, CUS0002, ...)
        private string GenerateNewCustomerId()
        {
            try
            {
                var allCustomers = customerBUS.GetAllCustomers();
                if (allCustomers == null || !allCustomers.Any())
                    return "CU0001";

                // Chuẩn hóa: chấp nhận cả "CU" và "CUS" để tránh lỗi dữ liệu cũ
                var validNumbers = allCustomers
                    .Where(c => c.CustomerId != null)
                    .Select(c => c.CustomerId.Trim().ToUpper())
                    .Where(id => id.StartsWith("CU") && id.Length >= 4) // ít nhất CU + số
                    .Select(id => 
                    {
                        string numPart = id.StartsWith("CU") ? id.Substring(3) : id.Substring(2);
                        return int.TryParse(numPart, out int num) ? num : -1;
                    })
                    .Where(num => num >= 0)
                    .ToList();

                int nextNumber;
                if (!validNumbers.Any())
                {
                    nextNumber = 1;
                }
                else
                {
                    int max = validNumbers.Max();
                    nextNumber = max + 1;
                }

                return $"CU{nextNumber:0000}";
            }
            catch (Exception ex)
            {
                // Log lỗi nếu cần
                MessageBox.Show("Lỗi tạo mã khách hàng tự động: " + ex.Message);
                // Vẫn trả về mã tạm dựa trên thời gian để không crash
                return "CU" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtCustomerName.Text.Trim();
            string phone = txtCustomerPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Vui lòng nhập số điện thoại.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (phone.Length < 10 || phone.Length > 11 || !phone.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải là 10 hoặc 11 chữ số.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng số điện thoại (trừ chính nó khi Update)
            var existing = customerBUS.GetCustomerByPhone(phone);
            if (existing != null && existing.CustomerId != customerId)
            {
                MessageBox.Show("Số điện thoại này đã được sử dụng bởi khách hàng khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            CustomerDTO customer = new CustomerDTO
            {
                CustomerId = txtCustomerId.Text, // Đã có sẵn (tự động hoặc cũ)
                CustomerName = name,
                CustomerPhone = phone
            };

            bool success = mode == "Insert"
                ? customerBUS.InsertCustomer(customer)
                : customerBUS.UpdateCustomer(customer);

            if (success)
            {
                MessageBox.Show(
                    mode == "Insert" ? "Thêm khách hàng thành công!" : "Cập nhật khách hàng thành công!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}