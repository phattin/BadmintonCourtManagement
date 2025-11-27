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
using BadmintonCourtManagement.BUS;

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    public partial class SupplyDetails : UserControl
    {
        // bus
        private ProductBUS productBus = new ProductBUS();
        // event
        public event Action<BillImportDetailDTO> productDeleted;
        public SupplyDetails()
        {
            InitializeComponent();
        }

        public void AddImportedProduct(BillImportDetailDTO importedProduct)
        {
            if (importedProduct == null) return;
            CardListPanel.RowCount += 1;
            CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F)); // Fixed height per card
            var card = CreateProductCard(importedProduct);
            CardListPanel.Controls.Add(card, 0, CardListPanel.RowCount - 1);
        }

        public void UpdateImportedProduct(BillImportDetailDTO importedProduct)
        {
            if (importedProduct == null) return;

            // Find and update the existing product card
            for (int i = 0; i < CardListPanel.Controls.Count; i++)
            {
                var control = CardListPanel.GetControlFromPosition(0, i);
                if (control != null && control is RoundedTableLayoutPanel panel)
                {
                    var infoPanel = panel.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
                    if (infoPanel != null)
                    {
                        var productIdLabel = infoPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.Contains("Mã sản phẩm:"));
                        if (productIdLabel != null && productIdLabel.Text.EndsWith(importedProduct.ProductId))
                        {
                            // Update labels
                            foreach (Label label in infoPanel.Controls.OfType<Label>())
                            {
                                if (label.Text.Contains("Số lượng:"))
                                {
                                    label.Text = "Số lượng: " + importedProduct.Quantity;
                                }
                                else if (label.Text.Contains("Giá:"))
                                {
                                    label.Text = "Giá: " + importedProduct.Price.ToString() + " VND";
                                }
                                else if (label.Text.Contains("Tổng tiền:"))
                                {
                                    label.Text = "Tổng tiền: " + importedProduct.TotalPrice.ToString() + " VND";
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
        private RoundedTableLayoutPanel CreateProductCard(BillImportDetailDTO product)
        {
            // Create card panel
            var cardPanel = new RoundedTableLayoutPanel
            {
                BackColor = Color.FromArgb(200, 250, 214),
                BorderRadius = 20,
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(20),
                Padding = new Padding(10),
                RowCount = 1
            };

            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 55.96F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.94F));
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Product image
            var picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 40, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
            string productImg = Path.Combine(projectRoot, "Img", "Product", productBus.GetProductById(product.ProductId).ProductImg);
            if (!File.Exists(productImg))
            {
                productImg = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");
            }
            if (File.Exists(productImg))
            {
                picture.Image = Image.FromFile(productImg);
            }

            // Info panel
            var infoPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                RowCount = 5
            };
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            var importBillIdLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Mã CT đơn nhập: " + product.ImportBillId,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var productIDLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Mã sản phẩm: " + product.ProductId,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var quantityLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Số lượng: " + product.Quantity,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var priceLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Giá: " + product.Price.ToString() + " VND",
                TextAlign = ContentAlignment.MiddleLeft
            };

            var totalPriceLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Tổng tiền: " + product.TotalPrice.ToString() + " VND",
                TextAlign = ContentAlignment.MiddleLeft
            };

            infoPanel.Controls.Add(importBillIdLabel, 0, 0);
            infoPanel.Controls.Add(productIDLabel, 0, 1);
            infoPanel.Controls.Add(quantityLabel, 0, 2);
            infoPanel.Controls.Add(priceLabel, 0, 3);
            infoPanel.Controls.Add(totalPriceLabel, 0, 4);

            // Add button
            var deleteBtn = new RoundedButton
            {
                BackColor = Color.Black,
                BackgroundColor = Color.Black,
                BorderRadius = 20,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Margin = new Padding(10, 60, 10, 60),
                Text = "Xóa",
                TextColor = Color.White
            };
            deleteBtn.Tag = product; // Store product reference
            deleteBtn.Click += deleteBtn_Click;
            deleteBtn.MouseEnter += buttonEnter;
            deleteBtn.MouseLeave += buttonLeave;

            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(deleteBtn, 2, 0);

            return cardPanel;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            var button = sender as RoundedButton;
            if (button?.Tag is BillImportDetailDTO product)
            {
                // Remove the product card from the panel
                for (int i = 0; i < CardListPanel.Controls.Count; i++)
                {
                    var control = CardListPanel.GetControlFromPosition(0, i);
                    if (control != null && control is RoundedTableLayoutPanel panel)
                    {
                        var infoPanel = panel.Controls.OfType<TableLayoutPanel>().FirstOrDefault();
                        if (infoPanel != null)
                        {
                            var productIdLabel = infoPanel.Controls.OfType<Label>().FirstOrDefault(l => l.Text.Contains("Mã sản phẩm:"));
                            if (productIdLabel != null && productIdLabel.Text.EndsWith(product.ProductId))
                            {
                                var result = MessageBox.Show($"Bạn có chắc muốn xóa sản phẩm {product.ProductId} khỏi phiếu nhập?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == DialogResult.Yes)
                                {
                                    CardListPanel.Controls.Remove(control);
                                    if (i >= 0 && i < CardListPanel.RowStyles.Count)
                                    {
                                        CardListPanel.RowStyles.RemoveAt(i);
                                    }
                                    CardListPanel.RowCount -= 1;
                                    // Raise event to notify parent form
                                    productDeleted?.Invoke(product);
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }


        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void FilterButton_MouseEnter(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void FilterButton_MouseLeave(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
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
