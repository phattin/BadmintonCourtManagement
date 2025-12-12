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

        public ProductDTO? ResultProduct { get; private set; }
        public ProductInsertGUI()
        {
            InitializeComponent();
        }

        public void InsertData(List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            // Xóa dữ liệu cũ
            brandComboBox.DataSource = null;
            categoryComboBox.DataSource = null;
            brandComboBox.Items.Clear();
            categoryComboBox.Items.Clear();
            brandComboBox.SelectedIndex = -1;
            categoryComboBox.SelectedIndex = -1;

            // Thêm dữ liệu vào ComboBox Thương hiệu
            if (brands != null && brands.Count > 0)
            {
                // Bind directly to DTO list for reliability
                brandComboBox.DisplayMember = "BrandName";
                brandComboBox.ValueMember = "BrandId";
                brandComboBox.DataSource = brands;
            }

            // Thêm dữ liệu vào ComboBox Loại sản phẩm
            if (types != null && types.Count > 0)
            {
                categoryComboBox.DisplayMember = "TypeProductName";
                categoryComboBox.ValueMember = "TypeProductId";
                categoryComboBox.DataSource = types;
            }

            // Also try to populate suppliers from BUS so the user doesn't need a separate call
            try
            {
                var supplierBus = new BadmintonCourtManagement.BUS.SupplierBUS();
                var suppliers = supplierBus.GetAllSuppliers();
                if (suppliers != null && suppliers.Count > 0)
                {
                    supplierComboBox.DisplayMember = "SupplierName";
                    supplierComboBox.ValueMember = "SupplierId";
                    supplierComboBox.DataSource = suppliers;
                }
            }
            catch
            {
                // ignore; caller can still call InsertSupplierData
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

            if (brandComboBox.SelectedItem == null || 
                categoryComboBox.SelectedItem == null || 
                supplierComboBox.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu, loại sản phẩm và nhà cung cấp.");
                return;
            }

            string brandId = GetComboBoxSelectedValue(brandComboBox);
            string typeId = GetComboBoxSelectedValue(categoryComboBox);
            string supplierId = GetComboBoxSelectedValue(supplierComboBox); // Lấy SupplierId
            string imgName = lbl_image.Text;

            if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(typeId) || string.IsNullOrEmpty(supplierId))
            {
                MessageBox.Show("Dữ liệu chọn không hợp lệ.");
                return;
            }

            ProductBUS productBUS = new ProductBUS();
            // List<ProductDTO> products = productBUS.GetAllProducts();
            string productId = productBUS.GenerateNextProductId();

            // Đúng thứ tự tham số của ProductDTO
            ProductDTO productDTO = new ProductDTO(
                productId, 
                productName, 
                supplierId,      // sửa ở đây: truyền supplierId
                imgName, 
                0,               // quantity
                brandId, 
                typeId, 
                0                // isDeleted
            );

            bool status = productBUS.InsertProduct(productDTO);
            if (!status)
            {
                MessageBox.Show("Thêm sản phẩm không thành công");
            }
            else
            {
                MessageBox.Show("Thêm sản phẩm thành công");
                ResultProduct = productDTO;
                ResetForm();
                this.FindForm()?.Close();
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

        // private string GenerateNextProductId(List<ProductDTO> products)
        // {
        //     const string prefix = "PD";
        //     const int digits = 5;

        //     if (products == null || products.Count == 0)
        //         return prefix + 1.ToString($"D{digits}");

        //     int maxNumber = 0;
        //     foreach (var p in products)
        //     {
        //         if (p == null || string.IsNullOrEmpty(p.ProductId)) continue;
        //         if (!p.ProductId.StartsWith(prefix, StringComparison.OrdinalIgnoreCase)) continue;

        //         string numericPart = p.ProductId.Substring(prefix.Length);
        //         if (int.TryParse(numericPart, out int n))
        //             if (n > maxNumber) maxNumber = n;
        //     }

        //     return prefix + (maxNumber + 1).ToString($"D{digits}");
        // }

        // Lớp hỗ trợ lưu Text + Value cho ComboBox
        private class ComboBoxItem
        {
            public string? Text { get; set; }
            public string? Value { get; set; }

            public override string ToString() => Text ?? "";
        }

        // Helper: get selected value from ComboBox whether it's bound to DTO or uses ComboBoxItem
        private string GetComboBoxSelectedValue(ComboBox cb)
        {
            if (cb.SelectedItem == null) return string.Empty;

            // If bound to DTO, try common property names
            var sel = cb.SelectedItem;
            // BrandDTO
            var brand = sel as BadmintonCourtManagement.DTO.BrandDTO;
            if (brand != null) return brand.BrandId ?? string.Empty;
            // TypeProductDTO
            var type = sel as BadmintonCourtManagement.DTO.TypeProductDTO;
            if (type != null) return type.TypeProductId ?? string.Empty;
            // SupplierDTO
            var sup = sel as BadmintonCourtManagement.DTO.SupplierDTO;
            if (sup != null) return sup.SupplierId ?? string.Empty;
            // Fallback to ComboBoxItem
            if (sel is ComboBoxItem cbi) return cbi.Value ?? string.Empty;
            // Last resort: try ToString
            return sel.ToString() ?? string.Empty;
        }

        private void tableLayout_storeItem_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void InsertSupplierData(List<SupplierDTO> suppliers)
{
    supplierComboBox.Items.Clear();
    supplierComboBox.SelectedIndex = -1;

    if (suppliers != null)
    {
        foreach (var supplier in suppliers)
        {
            supplierComboBox.Items.Add(new ComboBoxItem 
            { 
                Text = supplier.SupplierName, 
                Value = supplier.SupplierId 
            });
        }
    }
}
    }
}