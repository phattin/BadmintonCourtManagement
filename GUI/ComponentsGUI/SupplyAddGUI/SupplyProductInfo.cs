using GUI.ComponentsGUI;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    public partial class SupplyProductInfo : UserControl
    {
        // bus
        private TypeProductBUS typeBus = new TypeProductBUS();
        private BrandBUS brandBus = new BrandBUS();

        public SupplyProductInfo()
        {
            InitializeComponent();
        }

        private void LoadInfo()
        {
            // Load or initialize product info fields if necessary
        }

        public void SetProduct(ProductDTO product)
        {
            if (product == null) return;

            // Example: set UI controls. Replace the control names below
            // with the actual names in your designer for labels/textboxes.
            // For example: lblProductId, lblProductName, lblPrice, lblCurrentStock, txtQuantity, etc.

            // If those labels don't exist yet, create them in the Designer and name them accordingly.
            if (this.InvokeRequired)
            {
                this.Invoke(new Action(() => SetProduct(product)));
                return;
            }

            ProductID.Text = "Mã SP: " + product.ProductId;
            ProductName.Text = "Tên sản phẩm: " + product.ProductName;
            ProductType.Text = "Loại sản phẩm: " + typeBus.GetById(product.TypeId.ToString()).TypeProductName;
            ProductBrand.Text = "Nhãn hàng: " + brandBus.GetById(product.BrandId.ToString()).BrandName;
        }

        private void price_TextChanged(object sender, EventArgs e)
        {
            updatedTotalPrice();
        }

        private void updatedTotalPrice()
        {
            if (double.TryParse(textBox1.Text, out double importPrice) &&
                double.TryParse(QuantityBox.Text, out double quantity))
            {
                double totalPrice = importPrice * quantity;
                textBox3.Text = totalPrice.ToString();
            }
            else
            {
                textBox3.Text = "0";
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            RoundedButton btn = sender as RoundedButton;
            if (btn != null)
            {
                btn.BackgroundColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            RoundedButton btn = sender as RoundedButton;
            if (btn != null)
            {
                btn.BackgroundColor = Color.Black;
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // validate
            // empty check
            var textfields = new List<TextBox> { QuantityBox, textBox1, textBox2, textBox3 };
            errorProvider1.Clear();
            foreach (var textfield in textfields)
            {
                if (string.IsNullOrWhiteSpace(textfield.Text))
                {
                    errorProvider1.SetError(textfield, "Vui lòng nhập đầy đủ trường thông tin.");
                    return;
                }

                // numeric check
                if (!double.TryParse(textfield.Text, out double num) || num <= 0)
                {
                    errorProvider1.SetError(textfield, "Vui lòng nhập số lượng hợp lệ.");
                    return;
                }
            }

            // check price
            if (double.Parse(textBox1.Text) >= double.Parse(textBox2.Text))
            {
                errorProvider1.SetError(textBox1, "Giá nhập phải lớn hơn hoặc bằng giá bán.");
                return;
            }

            MessageBox.Show("Thêm sản phẩm vào phiếu nhập thành công (chưa tạo phiến mới)!");
            // TODO: update UI below - add product once the button is clicked and anything is perfect (don't know what that is)
            // create new bill import product detail objects in a list
            // after that, pass that list to the parent form (SupplyAddGUI) to handle
            // parent form should pass that list to SupplyDetails.cs to display
        }
    }
}
