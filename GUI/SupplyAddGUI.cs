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

        public SupplyAddGUI(AccountDTO acc)
        {
            currentAcc = acc;

            InitializeComponent();
            if (this.listProductPanel != null)
                this.listProductPanel.ProductSelected += OnProductSelected;

            if (this.infoProductPanel != null)
            {
                this.infoProductPanel.ProductImported += OnProductImported;
            }
        }


        private void OnProductSelected(ProductDTO product)
        {
            selectedProduct = product;

            // update the info panel (call method we added)
            if (this.infoProductPanel != null)
                this.infoProductPanel.SetProduct(product);
        }

        private void OnProductImported(BillImportDetailDTO importedProduct, StorageDTO storage, bool isDuplicate)
        {
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
            newBill = new ImportBillDTO(importBillId, productBus.GetProductById(importDetails[0].ProductId).SupplierId, employeeBus.GetEmployeeByUsername(currentAcc.Username).ToString(), totalPrice, ImportBillDTO.Option.Paid);

            // insert new bill import
            billImportBus.InsertBillImport(newBill);

            // inset bill import details
            foreach (var bill_detail in importDetails)
            {
                billDetailBus.InsertBillImportDetail(bill_detail);
            }

            // insert storages
            foreach (var s in storages)
            {
                StorageBUS.InsertStorage(s);
            }
            MessageBox.Show("Đã hoàn tất nhập hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
