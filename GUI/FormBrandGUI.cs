using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormBrandGUI : Form
    {
        private string mode; // "Insert" or "Update"
        private string? brandId; // Only used when Update
        private BrandBUS brandBUS = new BrandBUS();

        public FormBrandGUI(string mode, string? brandId = null, AccountDTO? currentAccount = null)
        {
            InitializeComponent();

            this.mode = mode;
            this.brandId = brandId; // Can be null when Insert

            // Disable brand ID editing
            txtBrandId.Enabled = false;
            txtBrandId.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);

            if (mode == "Insert")
            {
                lblTitle.Text = "THÊM THƯƠNG HIỆU";
                
                // AUTO-GENERATE NEW BRAND ID
                string newId = GenerateNewBrandId();
                txtBrandId.Text = newId;
                this.brandId = newId; // Assign immediately for use when saving
            }
            else if (mode == "Update")
            {
                lblTitle.Text = "CẬP NHẬT THƯƠNG HIỆU";

                txtBrandId.Text = brandId ?? "";

                if (brandId != null)
                {
                    var brand = brandBUS.GetById(brandId);
                    if (brand != null)
                    {
                        txtBrandName.Text = brand.BrandName ?? "";
                    }
                }
            }
        }

        // AUTO-GENERATE NEW BRAND ID (BR0001, BR0002, ...)
        private string GenerateNewBrandId()
        {
            try
            {
                var allBrands = brandBUS.GetAllBrands();
                if (allBrands == null || !allBrands.Any())
                    return "BR0001";

                var validNumbers = allBrands
                    .Where(b => b.BrandId != null)
                    .Select(b => b.BrandId.Trim().ToUpper())
                    .Where(id => id.StartsWith("BR") && id.Length >= 5)
                    .Select(id => 
                    {
                        string numPart = id.Substring(2);
                        return int.TryParse(numPart, out int num) ? num : -1;
                    })
                    .Where(num => num >= 0)
                    .ToList();

                int nextNumber = validNumbers.Any() ? validNumbers.Max() + 1 : 1;

                return $"BR{nextNumber:0000}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tạo mã thương hiệu tự động: " + ex.Message);
                return "BR" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtBrandName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên thương hiệu.", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check for duplicate brand name (except itself when Update)
            var existing = brandBUS.GetAllBrands()
                .FirstOrDefault(b => b.BrandName.Equals(name, StringComparison.OrdinalIgnoreCase) && b.BrandId != brandId);
            
            if (existing != null)
            {
                MessageBox.Show("Tên thương hiệu này đã tồn tại.", "Trùng lặp", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BrandDTO brand = new BrandDTO
            {
                BrandId = txtBrandId.Text,
                BrandName = name
            };

            bool success = mode == "Insert"
                ? brandBUS.InsertBrand(brand)
                : brandBUS.UpdateBrand(brand);

            if (success)
            {
                MessageBox.Show(
                    mode == "Insert" ? "Thêm thương hiệu thành công!" : "Cập nhật thương hiệu thành công!",
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
