using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;
using GUI.Utils;

namespace BadmintonCourtManagement.GUI
{
    public partial class ImportDetailsGUI : Form
    {
        // Layout components mirroring SupplyDetails (without delete button)
    private Panel Body = null!;
    private Panel MainPanel = null!;
    private TableLayoutPanel CardListPanel = null!;
    private Panel TitlePanel = null!;
    private Label Title = null!;

        public ImportDetailsGUI(List<BillImportDetailDTO> details)
        {
            InitializeComponent();
            Populate(details);
        }

        private void InitializeComponent()
        {
            SuspendLayout();
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 236, 213);
            Padding = new Padding(35, 39, 35, 39);
            ClientSize = new Size(1200, 800);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Text = "Chi tiết đơn nhập";

            // Body wrapper
            Body = new Panel
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            // MainPanel like SupplyDetails
            MainPanel = new Panel
            {
                AutoScroll = true,
                BackColor = Color.FromArgb(239, 248, 230),
                Dock = DockStyle.Fill,
                Margin = new Padding(0)
            };

            // TitlePanel
            TitlePanel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 80,
                Margin = new Padding(0)
            };
            Title = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                Text = "Chi tiết đơn nhập",
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(20, 0, 0, 0)
            };
            TitlePanel.Controls.Add(Title);

            // Card list panel (single column, stacked cards)
            CardListPanel = new TableLayoutPanel
            {
                AutoSize = true,
                BackColor = Color.FromArgb(239, 248, 230),
                ColumnCount = 1,
                Dock = DockStyle.Top,
                Margin = new Padding(0),
                Padding = new Padding(0),
            };
            CardListPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            MainPanel.Controls.Add(CardListPanel);
            MainPanel.Controls.Add(TitlePanel);
            Body.Controls.Add(MainPanel);
            Controls.Add(Body);
            ResumeLayout(false);
        }

        private void Populate(List<BillImportDetailDTO> details)
        {
            if (details == null || details.Count == 0)
            {
                MessageBox.Show("Không có chi tiết đơn nhập để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set dynamic title using import bill id from first item
            Title.Text = "Chi tiết đơn nhập: " + details[0].ImportBillId;

            // Build rows for each detail
            CardListPanel.SuspendLayout();
            CardListPanel.RowCount = 0;
            CardListPanel.RowStyles.Clear();

            foreach (var detail in details)
            {
                // Each card row with fixed height
                CardListPanel.RowCount += 1;
                CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 240F));
                var card = CreateProductCard(detail);
                CardListPanel.Controls.Add(card, 0, CardListPanel.RowCount - 1);
            }

            CardListPanel.ResumeLayout();
        }

        private TableLayoutPanel CreateProductCard(BillImportDetailDTO product)
        {
            // Card layout (3 columns like SupplyDetails): image | info | spacer
            var cardPanel = new TableLayoutPanel
            {
                BackColor = Color.FromArgb(200, 250, 214),
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(20),
                Padding = new Padding(10),
                RowCount = 1
            };
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Product image
            var picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 40, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\\..\\..\\"));
                var productDao = new ProductDAO();
                var productDTO = productDao.GetProductById(product.ProductId);
                string productImg = productDTO != null ? Path.Combine(projectRoot, "Img", "Product", productDTO.ProductImg) : string.Empty;
                if (string.IsNullOrEmpty(productImg) || !File.Exists(productImg))
                {
                    productImg = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");
                }
                if (File.Exists(productImg))
                {
                    picture.Image = Image.FromFile(productImg);
                }
            }
            catch { /* ignore image errors */ }

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

            var importBillIdLabel = MakeInfoLabel("Mã CT đơn nhập: " + product.ImportBillId, true);
            var productIDLabel = MakeInfoLabel("Mã sản phẩm: " + product.ProductId, true);
            var quantityLabel = MakeInfoLabel("Số lượng: " + product.Quantity, true);
            var priceLabel = MakeInfoLabel("Giá: " + product.Price + " VND", true);
            var totalPriceLabel = MakeInfoLabel("Tổng tiền: " + (product.Price * product.Quantity) + " VND", true);

            infoPanel.Controls.Add(importBillIdLabel, 0, 0);
            infoPanel.Controls.Add(productIDLabel, 0, 1);
            infoPanel.Controls.Add(quantityLabel, 0, 2);
            infoPanel.Controls.Add(priceLabel, 0, 3);
            infoPanel.Controls.Add(totalPriceLabel, 0, 4);

            // Spacer panel (instead of delete button)
            var spacer = new Panel { Dock = DockStyle.Fill };

            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(spacer, 2, 0);

            return cardPanel;
        }

        private Label MakeInfoLabel(string text, bool bold = false)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, bold ? FontStyle.Bold : FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0)
            };
        }
    }
}
