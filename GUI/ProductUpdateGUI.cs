using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace GUI
{
    public partial class ProductUpdateGUI : UserControl
    {
        private ProductDTO? _product;
        private string? _newImageName; // Lưu tên file ảnh mới (nếu có)
        public ProductDTO? ResultProduct { get; private set; }

        public ProductUpdateGUI()
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

            // Thêm dữ liệu cho ComboBox Trạng thái
            statusComboBox.Items.Clear();
            statusComboBox.Items.Add("Đang bán");
            statusComboBox.Items.Add("Ngừng hoạt động");
            statusComboBox.SelectedIndex = -1;
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

        public void LoadProduct(ProductDTO product, List<BrandDTO> brands, List<TypeProductDTO> types)
        {
            _product = product;
            _newImageName = null;

            InsertData(brands, types); // Sử dụng phương thức chung để load dữ liệu

            // Fill text fields
            txt_productName.Text = product.ProductName;
            lbl_image.Text = product.ProductImg ?? "";
            lbl_image.ForeColor = Color.Green;

            // Chọn giá trị cho các ComboBox
            if (!string.IsNullOrEmpty(product.BrandId))
            {
                brandComboBox.SelectedValue = product.BrandId;
            }
            if (!string.IsNullOrEmpty(product.TypeId))
            {
                categoryComboBox.SelectedValue = product.TypeId;
            }
            if (!string.IsNullOrEmpty(product.SupplierId))
            {
                supplierComboBox.SelectedValue = product.SupplierId;
            }

            // Chọn trạng thái dựa trên IsDeleted
            statusComboBox.SelectedIndex = product.IsDeleted == 0 ? 0 : 1;
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

                    _newImageName = fileName;
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
            if (_product == null)
            {
                MessageBox.Show("Không có sản phẩm để cập nhật.");
                return;
            }

            string productName = txt_productName.Text.Trim();
            if (string.IsNullOrEmpty(productName))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm.");
                return;
            }

            if (brandComboBox.SelectedItem == null || 
                categoryComboBox.SelectedItem == null || 
                supplierComboBox.SelectedItem == null ||
                statusComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn thương hiệu, loại sản phẩm, nhà cung cấp và trạng thái.");
                return;
            }

            string brandId = GetComboBoxSelectedValue(brandComboBox);
            string typeId = GetComboBoxSelectedValue(categoryComboBox);
            string supplierId = GetComboBoxSelectedValue(supplierComboBox);
            string imgName = string.IsNullOrEmpty(_newImageName) ? _product.ProductImg : _newImageName;
            int isDeleted = statusComboBox.SelectedIndex == 0 ? 0 : 1;

            if (string.IsNullOrEmpty(brandId) || string.IsNullOrEmpty(typeId) || string.IsNullOrEmpty(supplierId))
            {
                MessageBox.Show("Dữ liệu chọn không hợp lệ.");
                return;
            }

            ProductBUS productBUS = new ProductBUS();

            // Logic đặc biệt nếu chọn "Ngừng hoạt động"
            if (isDeleted == 1)
            {
                // Giả sử có method HasTransactions trong ProductBUS để kiểm tra sản phẩm đã giao dịch (ví dụ: có trong order_details)
                bool hasTransactions = productBUS.HasTransactions(_product.ProductId); 
                if (hasTransactions)
                {
                    // Kiểm tra số lượng == 0
                    if (_product.Quantity != 0)
                    {
                        MessageBox.Show("Sản phẩm còn tồn kho, không thể ngừng hoạt động.");
                        return;
                    }
                    else
                    {
                        if (MessageBox.Show("Bạn có chắc chắn muốn cập nhật trạng thái sản phẩm?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            bool deleteStatus = productBUS.DeleteProduct(_product.ProductId); // Giả sử có method DeleteProduct trong BUS
                            if (deleteStatus)
                            {
                                MessageBox.Show("Cập nhật trạng thái phẩm thành công");
                                ResultProduct = new ProductDTO(
                                    _product.ProductId,
                                    productName,
                                    supplierId,
                                    imgName,
                                    _product.Quantity,
                                    brandId,
                                    typeId,
                                    isDeleted
                                );
                                this.FindForm()?.Close();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật trạng thái phẩm thất bại");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    if (MessageBox.Show("Sản phẩm chưa giao dịch và sẽ bị xóa khỏi database. Bạn có chắc chắn?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        bool deleteStatus = productBUS.DatabaseDeleteProduct(_product.ProductId); // Giả sử có method DeleteProduct trong BUS
                        if (deleteStatus)
                        {
                            MessageBox.Show("Xóa sản phẩm thành công");
                            ResultProduct = new ProductDTO(
                                _product.ProductId,
                                productName,
                                supplierId,
                                imgName,
                                -1,
                                brandId,
                                typeId,
                                isDeleted
                            );
                            this.FindForm()?.Close();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Xóa sản phẩm thất bại");
                            return;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }

            // Update bình thường
            ProductDTO updatedProduct = new ProductDTO(
                _product.ProductId, 
                productName, 
                supplierId,
                imgName, 
                _product.Quantity, // Giữ nguyên quantity vì form không edit
                brandId, 
                typeId, 
                isDeleted
            );

            bool status = productBUS.UpdateProduct(updatedProduct);
            if (!status)
            {
                MessageBox.Show("Cập nhật sản phẩm không thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật sản phẩm thành công");
                ResultProduct = updatedProduct;
                // Set DialogResult so ShowDialog callers may detect success if they want
                this.FindForm()?.Close();
            }
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {
            // Reset form (tương tự insert, nhưng load lại data gốc cho update)
            if (_product != null)
            {
                txt_productName.Text = _product.ProductName;
                lbl_image.Text = _product.ProductImg ?? "";
                lbl_image.ForeColor = Color.Green;
                brandComboBox.SelectedValue = _product.BrandId;
                categoryComboBox.SelectedValue = _product.TypeId;
                supplierComboBox.SelectedValue = _product.SupplierId;
                statusComboBox.SelectedIndex = _product.IsDeleted == 0 ? 0 : 1;
                _newImageName = null;
            }
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

        // Lớp hỗ trợ lưu Text + Value cho ComboBox
        private class ComboBoxItem
        {
            public string? Text { get; set; }
            public string? Value { get; set; }

            public override string ToString() => Text ?? "";
        }
    }
}