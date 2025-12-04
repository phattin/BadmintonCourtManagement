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
        private BillImportDetailBUS detailBillBus = new BillImportDetailBUS();
        // list
        private List<BillImportDetailDTO> productListImported = new List<BillImportDetailDTO>();
        private List<StorageDTO> storageList = new List<StorageDTO>();
        public event Action<BillImportDetailDTO, StorageDTO, bool> ProductImported;
        private HashSet<string> generatedStorageIds = new HashSet<string>();

        private string billId = "";
        
        public SupplyProductInfo()
        {
            InitializeComponent();
            GenerateImportBillId();
        }

        private void GenerateImportBillId()
        {
            billId = billBus.GetMaxId();

            if (string.IsNullOrWhiteSpace(billId))
            {
                billId = "IB00001";
            }
            else
            {
                var match = Regex.Match(billId, @"^IB\d+$");
                if (match.Success)
                {
                    string numberPart = billId.Substring(2);
                    if (int.TryParse(numberPart, out var number))
                    {
                        number += productListImported.Count + 1;
                        if (number < 10)
                            billId = "IB0000" + number;
                        else if (number < 100)
                            billId = "IB000" + number;
                        else if (number < 1000)
                            billId = "IB00" + number;
                        else if (number < 10000)
                            billId = "IB0" + number;
                    }
                }
            }
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
            string productId = ProductID.Text.Replace("Mã sản phẩm: ", "");
            if (productId == "") {
                MessageBox.Show("Lỗi: Chưa chọn sản phẩm để nhập hàng");
                return;
            }
            // empty check
            // textBox1 = import price, textBox2 = profit percentage (%), textBox3 = total import cost
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

            // interpret textBox2 as profit percentage
            if (!int.TryParse(textBox2.Text, out int profitPercent) || profitPercent <= 0)
            {
                errorProvider1.SetError(textBox2, "Vui lòng nhập phần trăm lợi nhuận hợp lệ (> 0%).");
                return;
            }
            double importPriceValue = double.Parse(textBox1.Text);
            double profit = profitPercent / 100.0;
            double salePriceValue = Math.Round(importPriceValue * (1 + profit), 2);

            // check productId duplicate
            BillImportDetailDTO existingProduct = null;
            StorageDTO existingStorage = null;
            foreach (var item in productListImported)
            {
                if (item.ProductId == productId)
                {
                    item.Quantity = int.Parse(QuantityBox.Text);
                    item.Price = double.Parse(textBox1.Text); // import price
                    item.TotalPrice = item.Price * item.Quantity; // total import cost
                    existingProduct = item;
                    foreach (var storageItem in storageList)
                    {
                        if (storageItem.ProductId == item.ProductId)
                        {
                            storageItem.Quantity = item.Quantity;
                            storageItem.Price = salePriceValue; // computed sale price
                            storageItem.TotalPrice = Math.Round(storageItem.Quantity * salePriceValue, 2);
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
                string detailBillId = detailBillBus.GetMaxId();

                if (string.IsNullOrWhiteSpace(detailBillId))
                {
                    detailBillId = "ID00001";
                }
                else
                {
                    var match = Regex.Match(detailBillId, @"^ID\d+$");
                    if (match.Success)
                    {
                        string numberPart = detailBillId.Substring(2);

                        if (int.TryParse(numberPart, out var number))
                        {
                            number += productListImported.Count + 1;
                            if (number < 10)
                                detailBillId = "ID0000" + number.ToString();
                            else if (number < 100)
                                detailBillId = "ID000" + number.ToString();
                            else if (number < 1000)
                                detailBillId = "ID00" + number.ToString();
                            else if (number < 10000)
                                detailBillId = "ID0" + number.ToString();
                        }
                    } 
                    else
                    {
                        MessageBox.Show("Mã hóa đơn chi tiết không trùng regex.");  
                    }
                }

                BillImportDetailDTO newBill = new BillImportDetailDTO
                {
                    ImportBillDetailId = detailBillId,
                    ImportBillId = billId,
                    ProductId = productId,
                    Quantity = int.Parse(QuantityBox.Text),
                    Price = double.Parse(textBox1.Text), // import price
                    TotalPrice = double.Parse(textBox3.Text), // total import cost
                    Status = BillImportDetailDTO.Option.active
                };
                productListImported.Add(newBill);

                StorageDTO newStorage = new StorageDTO
                {
                    StorageId = GenerateStorageId(),
                    ImportBillDetailId = detailBillId,
                    ProductId = newBill.ProductId,
                    Quantity = newBill.Quantity,
                    // Store sale price (computed) in storage for selling
                    Price = salePriceValue,
                    TotalPrice = Math.Round(newBill.Quantity * salePriceValue, 2),
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
            
            var maxId = allStorages.Max(s => s.StorageId);
            if (string.IsNullOrWhiteSpace(maxId))
            {
                maxId = "ST00000";
            }
            var match = Regex.Match(maxId, @"^([A-Za-z]*)(\d+)$");
            
            if (match.Success)
            {    
                var prefix = match.Groups[1].Value;
                var numberPart = match.Groups[2].Value;
                if (int.TryParse(numberPart, out var number))
                {
                    string newId;
                    do {
                        number++;
                        newId = prefix + number.ToString("D5");
                    } while (generatedStorageIds.Contains(newId));

                    generatedStorageIds.Add(newId);
                    return newId;
                }
            }
            
            return "ST00001";
        }

        public void RemoveImportedProduct(BillImportDetailDTO product)
        {
            productListImported.RemoveAll(p => p.ProductId == product.ProductId);
            storageList.RemoveAll(s => s.ProductId == product.ProductId);
        }
    }
}
