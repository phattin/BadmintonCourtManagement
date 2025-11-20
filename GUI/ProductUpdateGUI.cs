using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductUpdateGUI : UserControl
    {
        private ProductDTO? _product;
        private string? _newImageName; // Lưu tên file ảnh mới (nếu có)

        public ProductUpdateGUI()
        {
            InitializeComponent();
        }

        public void LoadProduct(ProductDTO product, List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            _product = product;

            // Fill controls
            txtProductId.Text = product.ProductId;
            txtProductName.Text = product.ProductName;

            // Brands
            cmbBrand.DataSource = brands;
            cmbBrand.DisplayMember = "BrandName";
            cmbBrand.ValueMember = "BrandId";
            cmbBrand.SelectedValue = product.BrandId;

            // Types
            cmbType.DataSource = types;
            cmbType.DisplayMember = "TypeProductName";
            cmbType.ValueMember = "TypeProductId";
            cmbType.SelectedValue = product.TypeId;

            // Load image
            _newImageName = product.ProductImg;
            LoadImage(_newImageName);
        }

        private void LoadImage(string? imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                imageName = "DefaultProductImage.jpg";

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
            string imagePath = Path.Combine(projectRoot, "Img", "Product", imageName);

            if (!File.Exists(imagePath))
            {
                imagePath = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");
            }

            try
            {
                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    picProduct.Image = Image.FromStream(stream);
                }
            }
            catch
            {
                picProduct.Image = null;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("Không có sản phẩm để cập nhật.");
                return;
            }

            string productName = txtProductName.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                return;
            }

            string brandId = cmbBrand.SelectedValue?.ToString() ?? string.Empty;
            string typeId = cmbType.SelectedValue?.ToString() ?? string.Empty;

            if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(typeId))
            {
                MessageBox.Show("Vui lòng chọn thương hiệu và loại sản phẩm.");
                return;
            }

            // Dùng ảnh mới nếu có, nếu không thì giữ ảnh cũ

            string imgName = _newImageName?? _product.ProductImg; 

            ProductDTO updated = new ProductDTO(
                _product.ProductId,
                productName,
                imgName,
                _product.Quantity,
                brandId,
                typeId,
                _product.IsDeleted
            );

            ProductBUS bus = new ProductBUS();
            bool ok = bus.UpdateProduct(updated);
            if (ok)
            {
                MessageBox.Show("Cập nhật sản phẩm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.FindForm()?.Close();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

   
        
        private void btnChooseImage_Click(object sender, EventArgs e)
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

                    _newImageName = fileName;
                    using (var stream = new FileStream(destFilePath, FileMode.Open, FileAccess.Read))
                        {
                            picProduct.Image = Image.FromStream(stream);
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi lưu ảnh: " + ex.Message);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}