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

namespace BadmintonCourtManagement.GUI
{
    public partial class SupplyAddGUI : Form
    {
        ProductDTO selectedProduct;
        BillImportDetailDTO importedProduct;
        List<BillImportDetailDTO> importDetails = new();
        List<StorageDTO> storages = new();
        AccountDTO currentAcc;

        public ImportBillDTO? ResultBill { get; private set; }

        private List<StorageDTO> storageList = new List<StorageDTO>();

        public SupplyAddGUI(AccountDTO acc, List<StorageDTO> storageList)
        {
            currentAcc = acc;
            InitializeComponent();
            this.storageList = storageList;
            if (this.listProductPanel != null)
            {
                this.listProductPanel.ProductSelected += OnProductSelected;
            }

            if (this.infoProductPanel != null)
            {
                this.infoProductPanel.ProductImported += OnProductImported;
            }

            if (this.listDetailPanel != null)
            {
                this.listDetailPanel.productDeleted += OnProductDeleted;
            }
        }


        private void OnProductSelected(ProductDTO product)
        {
            if (product == null) return;

            // If there are already products in the import list, enforce same supplier
            if (importDetails != null && importDetails.Count > 0)
            {
                try
                {
                    var productBus = new ProductBUS();
                    var supplierBus = new SupplierBUS();
                    var firstProductId = importDetails[0].ProductId;
                    var firstProduct = productBus.GetProductById(firstProductId);
                    if (firstProduct != null && firstProduct.SupplierId != product.SupplierId)
                    {
                        MessageBox.Show($" Vui lòng chọn sản phẩm từ cùng một nhà cung cấp trong một lần nhập hàng.\n Nhà cung cấp của đơn nhập hàng này: {supplierBus.GetSupplierById(firstProduct.SupplierId).SupplierName}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    // Defensive: if lookup fails, show message and block selection
                    MessageBox.Show("Không thể kiểm tra nhà cung cấp hiện tại: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            selectedProduct = product;

            // update the info panel (call method we added)
            if (this.infoProductPanel != null)
                this.infoProductPanel.SetProduct(product);
        }

        private void OnProductImported(BillImportDetailDTO importedProduct, StorageDTO storage, bool isDuplicate)
        {
            if (importedProduct == null)
                return;

            // Defensive supplier validation before adding to master lists (in case it slipped through)
            if (!isDuplicate && importDetails.Count > 0)
            {
                try
                {
                    var productBus = new ProductBUS();
                    // supplier of previously added items (use first)
                    var firstProductId = importDetails[0].ProductId;
                    var firstProduct = productBus.GetProductById(firstProductId);
                    var newProduct = productBus.GetProductById(importedProduct.ProductId);

                    if (firstProduct != null && newProduct != null && firstProduct.SupplierId != newProduct.SupplierId)
                    {
                        MessageBox.Show("Không thể thêm sản phẩm: nhà cung cấp không khớp với các sản phẩm đã chọn trước đó.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể kiểm tra nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            this.importedProduct = importedProduct;
            if (this.listDetailPanel != null)
            {
                // If duplicate is true, you can choose to merge/update the existing item;
                if (isDuplicate)
                {
                    // Handle duplicate case if needed
                    this.listDetailPanel.UpdateImportedProduct(importedProduct);
                    foreach (var bill in importDetails)
                    {
                        if (bill.ProductId == importedProduct.ProductId)
                        {
                            importedProduct = bill;
                            break;
                        }
                    }
                    foreach (var s in storages)
                    {
                        if (s.ProductId == storage.ProductId)
                        {
                            storage = s;
                            break;
                        }
                    }
                }
                else
                {
                    this.listDetailPanel.AddImportedProduct(importedProduct);
                    importDetails.Add(importedProduct);
                    storages.Add(storage);
                }
            }
        }

        private void OnProductDeleted(BillImportDetailDTO product)
        {
            if (product == null)
                return;

            // Remove from importDetails
            importDetails.RemoveAll(b => b.ProductId == product.ProductId);

            // Remove from storages
            storages.RemoveAll(s => s.ProductId == product.ProductId);

            // remove from lists in SupplyProductInfo.cs if needed
            this.infoProductPanel.RemoveImportedProduct(product);
        }

        private void Done_Click(object sender, EventArgs e)
        {
            ImportBillDTO newBill = null;
            // bus
            BillImportBUS billImportBus = new BillImportBUS();
            ProductBUS productBus = new ProductBUS();
            EmployeeBUS employeeBus = new EmployeeBUS();
            BillImportDetailBUS billDetailBus = new BillImportDetailBUS();

            if (storages == null || importDetails == null)
            {
                MessageBox.Show("Lỗi: Chưa chọn sản phẩm để nhập hàng");
                return;
            }
            string importBillId = importDetails[0].ImportBillId;
            double totalPrice = 0;
            foreach (var bill in importDetails)
            {
                totalPrice += bill.TotalPrice;
            }
            // create new bill import
            newBill = new ImportBillDTO(importBillId, productBus.GetProductById(importDetails[0].ProductId).SupplierId, currentAcc.EmployeeId, totalPrice, ImportBillDTO.Option.delivered);

            // insert new bill import
            billImportBus.InsertBillImport(newBill);
            ResultBill = newBill;

            // inset bill import details
            foreach (var bill_detail in importDetails)
            {
                billDetailBus.InsertBillImportDetail(bill_detail);
            }

            // insert storages
            foreach (var s in storages)
            {
                bool result = StorageBUS.InsertStorage(s);
                if (!result)
                {
                    MessageBox.Show("Lỗi khi thêm kho hàng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    storageList.Add(s);
                    storageGUI storage = new storageGUI(currentAcc, storageList);
                    storage.ReloadStorage();
                }
            }

            // update product quantities
            foreach (var bill_detail in importDetails)
            {
                var product = productBus.GetProductById(bill_detail.ProductId);
                int quantityInStock = product.Quantity + bill_detail.Quantity;
                product.Quantity = quantityInStock;
                productBus.UpdateProduct(product);
            }

            MessageBox.Show("Đã hoàn tất nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SupplyAddGUI_Load(object sender, EventArgs e)
        {

        }

        private void supplyProductList1_Load(object sender, EventArgs e)
        {

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
    }
}
