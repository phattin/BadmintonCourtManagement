using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductInsertGUI : UserControl
    {
        public ProductInsertGUI()
        {
            InitializeComponent();
        }

        public void InsertData(List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            // Xóa dữ liệu cũ
            brandComboBox.Items.Clear();
            categoryComboBox.Items.Clear();
            brandComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;

            // Thêm dữ liệu vào ComboBox Thương hiệu
            if (brands != null)
            {
                foreach (var brand in brands)
                {
                    brandComboBox.Items.Add(new ComboBoxItem { Text = brand.BrandName, Value = brand.BrandId });
                }
            }

            // Thêm dữ liệu vào ComboBox Loại sản phẩm
            if (types != null)
            {
                foreach (var type in types)
                {
                    categoryComboBox.Items.Add(new ComboBoxItem { Text = type.TypeProductName, Value = type.TypeProductId });
                }
            }
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fileDialog.InitialDirectory = Path.Combine(Application.StartupPath, "BadmintonCourtManagement\\GUI\\Img\\Product");

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string sourceFilePath = fileDialog.FileName;
                    string fileName = fileDialog.SafeFileName;

                    string destFolder = Path.Combine(Application.StartupPath, @"..\..\..\Img\Product");
                    if (!Directory.Exists(destFolder))
                        Directory.CreateDirectory(destFolder);

                    string destFilePath = Path.Combine(destFolder, fileName);
                    File.Copy(sourceFilePath, destFilePath, true);

                    lbl_image.Text = fileName;
                    lbl_image.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                }
            }
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            string productName = txt_productName.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                return;
            }

            if (brandComboBox.SelectedItem == null || categoryComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và loại sản phẩm.");
                return;
            }

            string? brandId = ((ComboBoxItem)brandComboBox.SelectedItem).Value;
            string? typeId = ((ComboBoxItem)categoryComboBox.SelectedItem).Value;
            string imgName = lbl_image.Text;

            if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(typeId))
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và loại sản phẩm hợp lệ.");
                return;
            }

            ProductBUS productBUS = new ProductBUS();
            List<ProductDTO> products = productBUS.GetAllProducts();
            string productId = GenerateNextProductId(products);

            ProductDTO productDTO = new ProductDTO(productId, productName, imgName, 0, brandId, typeId, 0);

            bool status = productBUS.InsertProduct(productDTO);
            if (!status)
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                ResetForm();
            }
        }

        private void ResetForm()
        {
            txt_productName.Clear();
            lbl_image.Text = "";
            brandComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private string GenerateNextProductId(List<ProductDTO> products)
        {
            const string prefix = "PD";
            const int digits = 5;

            if (products == null || products.Count == 0)
                return prefix + 1.ToString($"D{digits}");

            int maxNumber = 0;
            foreach (var p in products)
            {
                if (p == null || string.IsNullOrEmpty(p.ProductId)) continue;
                if (!p.ProductId.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) continue;

                string numericPart = p.ProductId.Substring(prefix.Length);
                if (int.TryParse(numericPart, out int n))
                    if (n > maxNumber) maxNumber = n;
            }

            return prefix + (maxNumber + 1).ToString($"D{digits}");
        }

        // Lớp hỗ trợ lưu Text + Value cho ComboBox
        private class ComboBoxItem
        {
            public string? Text { get; set; }
            public string? Value { get; set; }

            public override string ToString() => Text ?? "";
        }

        private void tableLayout_storeItem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}