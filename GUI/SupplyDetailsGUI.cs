using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.GUI
{
    public partial class SupplyDetailsGUI : Form
    {
        private List<BillImportDetailDTO> importDetails;

        public SupplyDetailsGUI(List<BillImportDetailDTO> details)
        {
            InitializeComponent();
            this.importDetails = details;
            LoadImportDetails();
        }

        private void LoadImportDetails()
        {
            if (importDetails == null || importDetails.Count == 0)
            {
                MessageBox.Show("Không có chi tiết đơn nhập để hiển thị.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Set dynamic title using import bill id from first item
            Title.Text = "Chi tiết đơn nhập: " + importDetails[0].ImportBillId;

            // Clear existing cards
            CardListPanel.SuspendLayout();
            CardListPanel.Controls.Clear();
            CardListPanel.RowCount = 0;
            CardListPanel.RowStyles.Clear();

            // Build rows for each detail
            foreach (var detail in importDetails)
            {
                // Each card row with fixed height
                CardListPanel.RowCount += 1;
                CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 259F));
                var card = CreateProductCard(detail);
                CardListPanel.Controls.Add(card, 0, CardListPanel.RowCount - 1);
            }

            CardListPanel.ResumeLayout();
        }

        private TableLayoutPanel CreateProductCard(BillImportDetailDTO detail)
        {
            // Card layout (3 columns): image | info | addition
            var cardPanel = new TableLayoutPanel
            {
                BackColor = Color.FromArgb(200, 250, 214),
                ColumnCount = 3,
                Dock = DockStyle.Fill,
                Margin = new Padding(20),
                Padding = new Padding(10),
                RowCount = 1
            };
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            cardPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Product image
            var picture = new PictureBox
            {
                Dock = DockStyle.Fill,
                Margin = new Padding(40, 0, 40, 0),
                SizeMode = PictureBoxSizeMode.StretchImage
            };

            try
            {
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
                var productDao = new ProductDAO();
                var productDTO = productDao.GetProductById(detail.ProductId);
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

            // Info panel (left side details)
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

            var importDetailIdLabel = MakeInfoLabel("Mã CT đơn nhập: " + detail.ImportBillDetailId);
            var productIdLabel = MakeInfoLabel("Mã sản phẩm: " + detail.ProductId);
            var quantityLabel = MakeInfoLabel("Số lượng: " + detail.Quantity);
            var priceLabel = MakeInfoLabel("Giá: " + detail.Price.ToString("N0") + " VND");
            var totalPriceLabel = MakeInfoLabel("Tổng tiền: " + detail.TotalPrice.ToString("N0") + " VND");

            infoPanel.Controls.Add(importDetailIdLabel, 0, 0);
            infoPanel.Controls.Add(productIdLabel, 0, 1);
            infoPanel.Controls.Add(quantityLabel, 0, 2);
            infoPanel.Controls.Add(priceLabel, 0, 3);
            infoPanel.Controls.Add(totalPriceLabel, 0, 4);

            // Addition panel (right side details)
            var additionPanel = new TableLayoutPanel
            {
                ColumnCount = 1,
                Dock = DockStyle.Fill,
                Margin = new Padding(0),
                RowCount = 2
            };
            additionPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            additionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            additionPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            var statusLabel = MakeInfoLabel("Trạng thái: " + detail.Status.ToString());
            var spacer = new Label { Dock = DockStyle.Fill }; // Empty space

            additionPanel.Controls.Add(statusLabel, 0, 0);
            additionPanel.Controls.Add(spacer, 0, 1);

            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(additionPanel, 2, 0);

            return cardPanel;
        }

        private Label MakeInfoLabel(string text)
        {
            return new Label
            {
                Text = text,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
                Margin = new Padding(0)
            };
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_MouseEnter(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
        }
    }
}
