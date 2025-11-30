// FormSupplierGUI.cs
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormSupplierGUI : Form
    {
        private string mode; // "Insert" hoặc "Update"
        private string supplierId; // Chỉ dùng khi Update
        private SupplierBUS supplierBUS = new SupplierBUS();

        public FormSupplierGUI(string mode, string supplierId = null, AccountDTO currentAccount = null)
        {
            InitializeComponent();

            this.mode = mode;
            this.supplierId = supplierId; // Có thể null khi Insert

            // Tắt chỉnh sửa mã nhà cung cấp
            txtSupplierId.Enabled = false;
            txtSupplierId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            if (mode == "Insert")
            {
                lblTitle.Text = "THÊM NHÀ CUNG CẤP";
                
                // TỰ ĐỘNG TẠO MÃ NHÀ CUNG CẤP MỚI
                string newId = GenerateNewSupplierId();
                txtSupplierId.Text = newId;
                this.supplierId = newId; // Gán luôn để dùng khi lưu
            }
            else if (mode == "Update")
            {
                lblTitle.Text = "CẬP NHẬT NHÀ CUNG CẤP";

                txtSupplierId.Text = supplierId;

                var supplier = supplierBUS.GetSupplierById(supplierId);
                if (supplier != null)
                {
                    txtSupplierName.Text = supplier.SupplierName ?? "";
                    txtAddress.Text       = supplier.SupplierAddress ?? "";
                    txtEmail.Text         = supplier.SupplierEmail ?? "";
                }
            }
        }

        // TỰ ĐỘNG TẠO MÃ NHÀ CUNG CẤP MỚI (NCC0001, NCC0002, ...)
        private string GenerateNewSupplierId()
        {
            try
            {
                var allSuppliers = supplierBUS.GetAllSuppliers();
                if (allSuppliers == null || !allSuppliers.Any())
                    return "NCC0001";

                var validNumbers = allSuppliers
                    .Where(s => s.SupplierId != null)
                    .Select(s => s.SupplierId.Trim().ToUpper())
                    .Where(id => id.StartsWith("NCC") && id.Length >= 6)
                    .Select(id => 
                    {
                        string numPart = id.Substring(3);
                        return int.TryParse(numPart, out int num) ? num : -1;
                    })
                    .Where(num => num >= 0)
                    .ToList();

                int nextNumber = validNumbers.Any() ? validNumbers.Max() + 1 : 1;

                return $"NCC{nextNumber:0000}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã nhà cung cấp tự động: " + ex.Message);
                return "NCC" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name    = txtSupplierName.Text.Trim();
            string address = txtAddress.Text.Trim();
            string email   = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Vui lòng nhập email.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra định dạng email đơn giản
            if (!email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email không hợp lệ.", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra trùng email (trừ chính nó khi Update)
            var existing = supplierBUS.GetSupplierByEmail(email);
            if (existing != null && existing.SupplierId != supplierId)
            {
                MessageBox.Show("Email này đã được sử dụng bởi nhà cung cấp khác.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SupplierDTO supplier = new SupplierDTO
            {
                SupplierId      = txtSupplierId.Text,
                SupplierName    = name,
                SupplierAddress = address,
                SupplierEmail   = email,
                IsDeleted       = 0
            };

            bool success = mode == "Insert"
                ? supplierBUS.InsertSupplier(supplier)
                : supplierBUS.UpdateSupplier(supplier);

            if (success)
            {
                MessageBox.Show(
                    mode == "Insert" ? "Thêm nhà cung cấp thành công!" : "Cập nhật nhà cung cấp thành công!",
                    "Thành công",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}