using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Linq;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormTypeProduct : Form   // ĐÚNG: là Form, không phải UserControl
    {
        private string mode; // "Insert" hoặc "Update"
        private string? typeId;
        private TypeProductBUS typeProductBUS = new TypeProductBUS();

        public FormTypeProduct(string mode, string? typeId = null, AccountDTO? currentAccount = null)
        {
            InitializeComponent();
            this.mode = mode;
            this.typeId = typeId;


            // Thiết lập giao diện theo mode
            if (mode == "Insert")
            {
                lblTitle.Text = "      THÊM LOẠI MỚI";
                txtTypeId.Text = GenerateNewTypeId();
                txtTypeId.Enabled = false;
            }
            else if (mode == "Update" && !string.IsNullOrEmpty(typeId))
            {
                lblTitle.Text = "CẬP NHẬT LOẠI SẢN PHẨM";
                txtTypeId.Text = typeId;
                txtTypeId.Enabled = false;

                var dto = typeProductBUS.GetById(typeId);
                if (dto != null)
                {
                    txtTypeName.Text = dto.TypeProductName;
                }
            }

            this.Text = lblTitle.Text;
        }

        private string GenerateNewTypeId()
        {
            try
            {
                var all = typeProductBUS.GetAllTypeProducts();
                if (all == null || all.Count == 0)
                    return "TP0001";

                var maxNum = all
                    .Where(x => x.TypeProductId.StartsWith("TP"))
                    .Select(x => x.TypeProductId.Substring(2))
                    .Where(s => int.TryParse(s, out _))
                    .Select(s => int.Parse(s))
                    .DefaultIfEmpty(0)
                    .Max();

                return "TP" + (maxNum + 1).ToString("0000");
            }
            catch
            {
                return "TP" + DateTime.Now.ToString("yyyyMMddHHmmss");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtTypeName.Text.Trim();

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Vui lòng nhập tên loại sản phẩm!", "Thiếu thông tin",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var dto = new TypeProductDTO
            {
                TypeProductId = txtTypeId.Text,
                TypeProductName = name
            };

            bool success = mode == "Insert"
                ? typeProductBUS.InsertTypeProduct(dto)
                : typeProductBUS.UpdateTypeProduct(dto);

            if (success)
            {
                MessageBox.Show(mode == "Insert"
                    ? "Thêm loại sản phẩm thành công!"
                    : "Cập nhật thành công!",
                    "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Thao tác thất bại. Có thể tên loại đã tồn tại hoặc dữ liệu không hợp lệ.",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }
    }
}