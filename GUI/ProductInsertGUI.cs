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
            // AI Generated code
            brand_listBox.DataSource = brands?.ToList() ?? new List<BrandDTO>();
            brand_listBox.DisplayMember = nameof(BrandDTO.BrandName);
            brand_listBox.ValueMember = nameof(BrandDTO.BrandId);

            category_listBox.DataSource = types?.ToList() ?? new List<TypeProductDTO>();
            category_listBox.DisplayMember = nameof(TypeProductDTO.TypeProductName);
            category_listBox.ValueMember = nameof(TypeProductDTO.TypeProductId);
            // End of AI Generated code
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
            string productName = txt_productName.Text;
            var selectedBrand = brand_listBox.CheckedItems.Cast<BrandDTO>().FirstOrDefault();
            var selectedType = category_listBox.CheckedItems.Cast<TypeProductDTO>().FirstOrDefault();
            if (selectedBrand == null || selectedType == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và loại sản phẩm.");
                return;
            }

            string brandId = selectedBrand.BrandId;
            string typeId = selectedType.TypeProductId;
            string imgName = lbl_image.Text;

            // find typeId
            // TypeProductBUS typeProductBUS = new TypeProductBUS();
            // List<TypeProductDTO> typeProductDTOs = typeProductBUS.GetAllTypeProducts();

            // foreach (var type in typeProductDTOs) {
            //     if (type.TypeProductName == productCategory) { 
            //         productCategory = type.TypeProductId.ToString(); // error: show ProductDTO.BrandId or something instead of just string id
            //         break;
            //     }
            // }

            // // find brandId
            // BrandBUS brandBUS = new BrandBUS();
            // List<BrandDTO> brandDTOs = brandBUS.GetAllBrands();

            // foreach (var brand in brandDTOs)
            // {
            //     if (brand.BrandName == productBrand)
            //     {
            //         productBrand = brand.BrandId.ToString(); // error: show ProductDTO.BrandId or something instead of just string id
            //         break;
            //     }
            // }

            // set productId
            ProductBUS productBUS = new ProductBUS();
            List<ProductDTO> products = productBUS.GetAllProducts();
            string productId = GenerateNextProductId(products);

            ProductDTO productDTO = new ProductDTO(productId, productName, imgName, 0, brandId, typeId, 0);
            MessageBox.Show($"Id: {productId} \nName: {productName} \nimgName: {imgName} \n brandId: {brandId} \ntypeId: {typeId}");
            bool status = productBUS.InsertProduct(productDTO);
            if (!status)
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            } 
            else
            {
                MessageBox.Show("Thêm sản phẩm thành công");
            }
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
