using GUI.ComponentsGUI;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
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

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    public partial class SupplyProductList : UserControl
    {
        // list
        private List<ProductDTO> productList = new List<ProductDTO>();
        // bus
        private ProductBUS productBus = new ProductBUS();
        // event
        public event Action<ProductDTO> ProductSelected;
        public SupplyProductList()
        {
            InitializeComponent();
            this.Load += SupplyProductList_Load;
        }

        private void SupplyProductList_Load(object sender, EventArgs e)
        {
            LoadProducts();
        }

        public void LoadProducts()
        {
            try
            {
                productList = productBus.GetAllProducts();
                CardListPanel.Controls.Clear();
                CardListPanel.RowStyles.Clear();
                CardListPanel.RowCount = productList.Count;
                
                for (int i = 0; i < productList.Count; i++)
                {
                    CardListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 260F)); // Fixed height per card
                    var card = CreateProductCard(productList[i]);
                    CardListPanel.Controls.Add(card, 0, i);
                }
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách sản phẩm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private RoundedTableLayoutPanel CreateProductCard(ProductDTO product)
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
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 49.5F));
            cardPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.5F));
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
            string productImg = Path.Combine(projectRoot, "Img", "Product", product.ProductImg);
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
                RowCount = 2
            };
            infoPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            infoPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            var productIDLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Mã sản phẩm: " + product.ProductId,
                TextAlign = ContentAlignment.MiddleLeft
            };

            var productNameLabel = new Label
            {
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                Text = "Tên: " + product.ProductName,
                TextAlign = ContentAlignment.MiddleLeft
            };

            infoPanel.Controls.Add(productIDLabel, 0, 0);
            infoPanel.Controls.Add(productNameLabel, 0, 1);

            // Add button
            var addButton = new RoundedButton
            {
                BackColor = Color.Black,
                BackgroundColor = Color.Black,
                BorderRadius = 20,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold),
                ForeColor = Color.White,
                Margin = new Padding(10, 60, 10, 60),
                Text = "Thêm",
                TextColor = Color.White
            };
            addButton.Tag = product; // Store product reference
            addButton.Click += AddButton_Click;
            addButton.MouseEnter += buttonEnter;
            addButton.MouseLeave += buttonLeave;

            cardPanel.Controls.Add(picture, 0, 0);
            cardPanel.Controls.Add(infoPanel, 1, 0);
            cardPanel.Controls.Add(addButton, 2, 0);

            return cardPanel;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var button = sender as RoundedButton;
            if (button?.Tag is ProductDTO product)
            {
                // raise the event so the parent form can handle selection
                ProductSelected?.Invoke(product);
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
