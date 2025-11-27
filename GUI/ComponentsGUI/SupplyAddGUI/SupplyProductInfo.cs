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
using System.Text.RegularExpressions;

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    public partial class SupplyProductInfo : UserControl
    {
        // bus
        private TypeProductBUS typeBus = new TypeProductBUS();
        private BrandBUS brandBus = new BrandBUS();
        private BillImportBUS billBus = new BillImportBUS();
        // list
        private List<BillImportDetailDTO> productListImported = new List<BillImportDetailDTO>();
        private List<StorageDTO> storageList = new List<StorageDTO>();
        public event Action<BillImportDetailDTO, StorageDTO, bool> ProductImported;

        public SupplyProductInfo()
        {
            InitializeComponent();
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

            ProductID.Text = "Mã sản phẩm: " + product.ProductId;
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
                errorProvider1.SetError(textBox2, "Đơn giá nhập phải nhỏ hơn đơn giá bán.");
                return;
            }

            // check productId duplicate
            BillImportDetailDTO existingProduct = null;
            StorageDTO existingStorage = null;
            foreach (var item in productListImported)
            {
                if (item.ProductId == ProductID.Text.Replace("Mã sản phẩm: ", ""))
                {
                    item.Quantity = int.Parse(QuantityBox.Text);
                    item.Price = double.Parse(textBox1.Text);
                    item.TotalPrice = item.Price * item.Quantity;
                    existingProduct = item;
                    foreach (var storageItem in storageList)
                    {
                        if (storageItem.ProductId == item.ProductId)
                        {
                            storageItem.Quantity = item.Quantity;
                            storageItem.Price = item.Price;
                            storageItem.TotalPrice = item.TotalPrice;
                            existingStorage = storageItem;
                            break;
                        }
                    }
                    break;
                }
            }

            if (existingProduct != null)
            {
                MessageBox.Show("Cập nhật sản phẩm trong phiếu nhập thành công");
                ProductImported?.Invoke(existingProduct, existingStorage, true);
            }
            else
            {
                var billId = billBus.GetMaxId();

                if (string.IsNullOrWhiteSpace(billId))
                {
                    billId = "IB00001";
                }
                else
                {
                    var match = Regex.Match(billId, @"^([A-Za-z]*)(\d+)$");
                    if (match.Success)
                    {
                        var prefix = match.Groups[1].Value;
                        var numberPart = match.Groups[2].Value;
                        if (int.TryParse(numberPart, out var number))
                        {
                            number += productListImported.Count + 1;
                            billId = prefix + number.ToString().PadLeft(numberPart.Length, '0');
                        }
                    }
                }

                BillImportDetailDTO newBill = new BillImportDetailDTO
                {
                    ImportBillId = billId,
                    ProductId = ProductID.Text.Replace("Mã sản phẩm: ", ""),
                    Quantity = int.Parse(QuantityBox.Text),
                    Price = double.Parse(textBox1.Text),
                    TotalPrice = double.Parse(textBox3.Text),
                    Status = BillImportDetailDTO.Option.active
                };
                productListImported.Add(newBill);

                StorageDTO newStorage = new StorageDTO
                {
                    StorageId = GenerateStorageId(),
                    ImportBillId = billId,
                    ProductId = newBill.ProductId,
                    Quantity = newBill.Quantity,
                    Price = newBill.Price,
                    TotalPrice = newBill.TotalPrice,
                    CreatedAt = DateTime.Now,
                    Status = StorageDTO.Option.active
                };

                storageList.Add(newStorage);

                ProductImported?.Invoke(newBill, newStorage, false);


                MessageBox.Show("Thêm sản phẩm vào phiếu nhập thành công");
            }
            // TODO: update UI below - add product once the button is clicked and anything is perfect (don't know what that is)
            // create new bill import product detail objects in a list
            // after that, pass that list to the parent form (SupplyAddGUI) to handle
            // parent form should pass that list to SupplyDetails.cs to display
        }

        private string GenerateStorageId()
        {
            // Similar pattern to your bill ID generation
            var allStorages = StorageBUS.GetAllStorages();
            
            if (allStorages == null || allStorages.Count == 0)
                return "KH001";
            
            var lastId = allStorages.OrderByDescending(s => s.StorageId).First().StorageId;
            var match = Regex.Match(lastId, @"^([A-Za-z]*)(\d+)$");
            
            if (match.Success)
            {
                var prefix = match.Groups[1].Value;
                var numberPart = match.Groups[2].Value;
                if (int.TryParse(numberPart, out var number))
                {
                    number += allStorages.Count + 1;
                    return prefix + number.ToString().PadLeft(numberPart.Length, '0');
                }
            }
            
            return "KH001";
        }

        public void RemoveImportedProduct(BillImportDetailDTO product)
        {
            productListImported.RemoveAll(p => p.ProductId == product.ProductId);
            storageList.RemoveAll(s => s.ProductId == product.ProductId);
        }
    }
}
