using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductDetailsGUI : Form
    {
        private readonly ProductDTO _product;

        public ProductDetailsGUI(ProductDTO product)
        {
            _product = product ?? throw new ArgumentNullException(nameof(product));
            InitializeComponentManual();
        }

        private void InitializeComponentManual()
        {
            Text = "Chi tiết sản phẩm";
            StartPosition = FormStartPosition.CenterParent;
            Size = new Size(520, 640);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;

            var main = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 6,
                Padding = new Padding(12)
            };
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F)); // title
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 220F)); // image
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F)); // name
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F)); // id
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // other details
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F)); // buttons

            var title = new Label
            {
                Text = "Thông tin sản phẩm",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var pic = new PictureBox
            {
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            // Load image
            pic.Image = LoadProductImage(_product.ProductImg);

            var lblName = new Label
            {
                Text = $"Tên: {_product.ProductName}",
                Font = new Font("Segoe UI", 11F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(6, 0, 0, 0)
            };

            var lblId = new Label
            {
                Text = $"Mã: {_product.ProductId}",
                Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
                Padding = new Padding(6, 0, 0, 0)
            };

            // Other details panel
            var details = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 3,
                AutoSize = true
            };
            details.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120F));
            details.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));

            var lblBrandTitle = new Label { Text = "Thương hiệu:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblBrand = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblTypeTitle = new Label { Text = "Loại:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblType = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblQtyTitle = new Label { Text = "Số lượng:", Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblQty = new Label { Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

            // Try to fetch brand/type names via BUS
            try
            {
                var brandBus = new BrandBUS();
                var typeBus = new TypeProductBUS();
                var brand = brandBus.GetAllBrands().Find(b => b.BrandId == _product.BrandId);
                var type = typeBus.GetAllTypeProducts().Find(t => t.TypeProductId == _product.TypeId);
                lblBrand.Text = brand?.BrandName ?? _product.BrandId ?? string.Empty;
                lblType.Text = type?.TypeProductName ?? _product.TypeId ?? string.Empty;
            }
            catch
            {
                lblBrand.Text = _product.BrandId ?? string.Empty;
                lblType.Text = _product.TypeId ?? string.Empty;
            }

            lblQty.Text = _product.Quantity.ToString();

            details.Controls.Add(lblBrandTitle, 0, 0);
            details.Controls.Add(lblBrand, 1, 0);
            details.Controls.Add(lblTypeTitle, 0, 1);
            details.Controls.Add(lblType, 1, 1);
            details.Controls.Add(lblQtyTitle, 0, 2);
            details.Controls.Add(lblQty, 1, 2);

            var btnClose = new Button
            {
                Text = "Đóng",
                Dock = DockStyle.Right,
                Width = 100,
                Height = 34,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btnClose.Click += (s, e) => Close();

            main.Controls.Add(title, 0, 0);
            main.Controls.Add(pic, 0, 1);
            main.Controls.Add(lblName, 0, 2);
            main.Controls.Add(lblId, 0, 3);
            main.Controls.Add(details, 0, 4);
            main.Controls.Add(btnClose, 0, 5);

            Controls.Add(main);
        }

        private Image? LoadProductImage(string? imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                imageName = "DefaultProductImage.jpg";

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\.."));
            string imagePath = Path.Combine(projectRoot, "Img", "Product", imageName);

            if (!File.Exists(imagePath))
            {
                imagePath = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");
                if (!File.Exists(imagePath))
                    return null;
            }

            try
            {
                using (var stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                {
                    return new Bitmap(stream);
                }
            }
            catch
            {
                return null;
            }
        }
    }
}
