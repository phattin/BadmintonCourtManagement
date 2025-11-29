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
        private string? supplierId;
        private SupplierBUS supplierBUS = new SupplierBUS();

        public FormSupplierGUI(string mode, string? supplierId = null, AccountDTO? currentAccount = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.supplierId = supplierId;

            if (mode == "Insert")
            {
                lblTitle.Text = "     THÊM NHÀ CUNG CẤP";
                txtSupplierId.Text = GenerateNewSupplierId();
                txtSupplierId.Enabled = false;
            }
            else if (mode == "Update" && !string.IsNullOrEmpty(supplierId))
            {
                lblTitle.Text = "CẬP NHẬT NHÀ CUNG CẤP";
                txtSupplierId.Text = supplierId;
                txtSupplierId.Enabled = false;

                LoadSupplierData(supplierId); // Gọi hàm riêng để dễ debug
            }

            this.Text = lblTitle.Text;
        }

        private void LoadSupplierData(string id)
        {
            try
            {
                var dto = supplierBUS.GetSupplierById(id);

                if (dto == null)
                {
                    MessageBox.Show($"Không tìm thấy nhà cung cấp với mã: {id}\nCó thể đã bị xóa hoặc không tồn tại.",
                        "Không tìm thấy", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                // Đổ dữ liệu lên form
                txtSupplierName.Text = dto.SupplierName ?? "";
                txtAddress.Text      = dto.SupplierAddress ?? "";
                txtEmail.Text        = dto.SupplierEmail ?? "";

                // Nếu bạn có cột IsDeleted, vẫn cho phép sửa (thường là có)
                // Không cần làm gì thêm
            }
            catch (Exception ex)
            {
            MessageBox.Show("Lỗi khi tải dữ liệu nhà cung cấp:\n" + ex.Message, 
                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private string GenerateNewSupplierId()
        {
            try
            {
                var all = supplierBUS.GetAllSuppliers();
                if (all == null || all.Count == 0)
                    return "NCC001";

                var maxNum = all
                    .Where(x => x.SupplierId.StartsWith("SPU"))
                    .Select(x => x.SupplierId.Substring(4))
                    .Where(s => int.TryParse(s, out _))
                    .Select(int.Parse)
                    .DefaultIfEmpty(0)
                    .Max();

                return "NCC" + (maxNum + 1).ToString("000");
            }
            catch
            {
                return "NCC" + DateTime.Now.ToString("yyMMddHHmm");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtSupplierName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string address = txtAddress.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên nhà cung cấp!", "Thiếu thông tin", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSupplierName.Focus();
                return;
            }
            var dto = new SupplierDTO
            {
                SupplierId = txtSupplierId.Text,
                SupplierName = name,
                SupplierAddress = address,
                SupplierEmail = email,
                IsDeleted = 0
            };

            bool success;
            string message;

            try
            {
                if (mode == "Insert")
                {
                    success = supplierBUS.InsertSupplier(dto);
                    message = success ? "Thêm nhà cung cấp thành công!" : "Thêm thất bại! Có thể mã hoặc tên đã tồn tại.";
                }
                else
                {
                    success = supplierBUS.UpdateSupplier(dto);
                    message = success ? "Cập nhật thành công!" : "Cập nhật thất bại!";
                }

                if (success)
                {
                    MessageBox.Show(message, "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}