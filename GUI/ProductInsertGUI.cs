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
            // Xóa nội dung cũ của panel
            brandPanel.Controls.Clear();
            categoryPanel.Controls.Clear();
            selectedBrandRadio = null;
            selectedCategoryRadio = null;

            // Tạo RadioButton cho Thương hiệu
            if (brands != null)
            {
                foreach (var brand in brands)
                {
                    var radio = new RadioButton
                    {
                        Text = brand.BrandName,
                        Tag = brand.BrandId,
                        AutoSize = true,
                        Margin = new Padding(0, 0, 0, 5)
                    };
                    radio.CheckedChanged += (s, e) =>
                    {
                        if (radio.Checked) selectedBrandRadio = radio;
                    };
                    brandPanel.Controls.Add(radio);
                }
            }

            // Tạo RadioButton cho Loại sản phẩm
            if (types != null)
            {
                foreach (var type in types)
                {
                    var radio = new RadioButton
                    {
                        Text = type.TypeProductName,
                        Tag = type.TypeProductId,
                        AutoSize = true,
                        Margin = new Padding(0, 0, 0, 5)
                    };
                    radio.CheckedChanged += (s, e) =>
                    {
                        if (radio.Checked) selectedCategoryRadio = radio;
                    };
                    categoryPanel.Controls.Add(radio);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayout_storeItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Label btn = sender as Label;
            if (btn != null)
            {
                btn.BackColor = Color.Black;
            }
        }

        private void chooseImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";
            fileDialog.InitialDirectory = "BadmintonCourtManagement\\GUI\\Img\\Product";

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // The full path of the user's selected file
                    string sourceFilePath = fileDialog.FileName;

                    // The name of the file, without the path
                    string fileName = fileDialog.SafeFileName;

                    // Define the destination folder relative to the application's executable
                    string appDirectory = Path.GetDirectoryName(Application.ExecutablePath);
                    MessageBox.Show(appDirectory);
                    // Navigate up to the project folder and then to your Img folder
                    // This might need adjustment based on your project structure.
                    // A common structure is bin/Debug, so you might go up two levels.
                    string destFolder = Path.Combine(appDirectory, @"..\..\..\Img\Product");

                    // Ensure the destination directory exists
                    if (!Directory.Exists(destFolder))
                    {
                        Directory.CreateDirectory(destFolder);
                    }

                    // Construct the full destination path
                    string destFilePath = Path.Combine(destFolder, fileName);

                    // Copy the file to the destination, with the option to overwrite
                    File.Copy(sourceFilePath, destFilePath, true);

                    lbl_image.Text = fileName;

                    // Now 'destFilePath' holds the path to the copied image within your project structure.
                    // You can store this path in a database or use it to display the image.
                    // For example:
                    // pictureBox1.Image = new Bitmap(destFilePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error saving file: " + ex.Message);
                }
            }
            else
            {
                // User cancelled the dialog
            }
        }

        private void brand_listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       private void saveBtn_Click(object sender, EventArgs e)
        {
            string productName = txt_productName.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                return;
            }

            if (selectedBrandRadio == null || selectedCategoryRadio == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và loại sản phẩm.");
                return;
            }

            string brandId = selectedBrandRadio.Tag.ToString();
            string typeId = selectedCategoryRadio.Tag.ToString();
            string imgName = lbl_image.Text;

            // Tạo ID sản phẩm
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
                // Reset form nếu cần
                ResetForm();
            }
        }
        private void ResetForm()
        {
            txt_productName.Clear();
            lbl_image.Text = "";
            selectedBrandRadio = null;
            selectedCategoryRadio = null;
            foreach (RadioButton rb in brandPanel.Controls) rb.Checked = false;
            foreach (RadioButton rb in categoryPanel.Controls) rb.Checked = false;
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
                if (p == null || string.IsNullOrEmpty(p.ProductId))
                    continue;

                if (!p.ProductId.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
                    continue;

                string numericPart = p.ProductId.Substring(prefix.Length);
                if (int.TryParse(numericPart, out int n))
                {
                    if (n > maxNumber) maxNumber = n;
                }
            }

            return prefix + (maxNumber + 1).ToString($"D{digits}");
        }
    }
}
