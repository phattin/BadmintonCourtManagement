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
        public SupplyProductInfo()
        {
            InitializeComponent();
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Black;
            }
        }
<<<<<<< Updated upstream
=======

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

            // check import price (textbox1) < sell price (textbox2)
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
                            storageItem.Price = double.Parse(textBox2.Text);
                            storageItem.TotalPrice = item.Quantity * storageItem.Price;
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
                    ImportBillDetailId = billId,
                    ProductId = newBill.ProductId,
                    Quantity = newBill.Quantity,
                    Price = double.Parse(textBox2.Text),
                    TotalPrice = newBill.Quantity * double.Parse(textBox2.Text),
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
>>>>>>> Stashed changes
    }
}
