using GUI.ComponentsGUI;
using BadmintonCourtManagement.DTO;
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
        public SupplyAddGUI()
        {
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

        private void OnProductImported(BillImportDetailDTO importedProduct, bool isDuplicate)
        {
            this.importedProduct = importedProduct;
            if (this.listDetailPanel != null)
            {
                // If duplicate is true, you can choose to merge/update the existing item;
                if (isDuplicate)
                {
                    // Handle duplicate case if needed
                    this.listDetailPanel.UpdateImportedProduct(importedProduct);
                } 
                else
                {    
                    this.listDetailPanel.AddImportedProduct(importedProduct);
                }
            }
        }

        private void Done_Click(object sender, EventArgs e)
        {
            // Handle the done button click event
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
