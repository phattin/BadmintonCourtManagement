using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormCustomerGUI : UserControl
    {
        private string mode; // Insert hoặc Update
        private string customerId;
        private CustomerBUS customerBUS = new CustomerBUS();

        public FormCustomerGUI(string mode, string customerId, AccountDTO currentAccount)
        {
            this.mode = mode;
            this.customerId = customerId;

            InitializeComponent();

            // Gán sẵn ID khách hàng (label hiển thị, không sửa)
            CustomerID.Text = customerId;

            if (mode == "Insert")
            {
                Title.Text = "Thêm khách hàng";
                txtCustomerName.Text = "";
                txtCustomerPhone.Text = "";
            }
            else if (mode == "Update")
            {
                Title.Text = "Sửa khách hàng";

                // Load thông tin khách hàng
                var customer = customerBUS.GetCustomerById(customerId);
                if (customer != null)
                {
                    txtCustomerName.Text = customer.CustomerName;
                    txtCustomerPhone.Text = customer.CustomerPhone;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            string customerName = txtCustomerName.Text.Trim();
            string customerPhone = txtCustomerPhone.Text.Trim();

            if (string.IsNullOrWhiteSpace(customerName) || string.IsNullOrWhiteSpace(customerPhone))
            {
                MessageBox.Show("Tên khách hàng và số điện thoại không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ---- THÊM MỚI ----
            if (mode == "Insert")
            {
                if (customerBUS.InsertCustomer(new CustomerDTO
                {
                    CustomerId = customerId,
                    CustomerName = customerName,
                    CustomerPhone = customerPhone
                }))
                {
                    MessageBox.Show("Thêm khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    return;
                }
            }

            // ---- CẬP NHẬT ----
            else if (mode == "Update")
            {
                if (customerBUS.UpdateCustomer(new CustomerDTO
                {
                    CustomerId = customerId,
                    CustomerName = customerName,
                    CustomerPhone = customerPhone
                }))
                {
                    MessageBox.Show("Cập nhật khách hàng thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();
        }

        private void lblCustomerID_Click(object sender, EventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}