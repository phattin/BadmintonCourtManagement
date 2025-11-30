
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
            Size = new Size(700, 520);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            BackColor = Color.White;

            var main = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(12),
                BackColor = Color.White
            };

            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            main.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            main.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));

            var header = new Label
            {
                Text = "THÔNG TIN SẢN PHẨM",
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 103),
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Content: two columns - image (fixed) and details
            var content = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 1,
                Padding = new Padding(8)
            };
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 260F));
            content.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

            // Image panel
            var imgPanel = new Panel { Dock = DockStyle.Fill, Padding = new Padding(6) };
            var picProduct = new PictureBox { Dock = DockStyle.Fill, SizeMode = PictureBoxSizeMode.Zoom, BorderStyle = BorderStyle.FixedSingle };
            picProduct.Image = LoadProductImage(_product.ProductImg);
            imgPanel.Controls.Add(picProduct);

            // Details stack
            var details = new TableLayoutPanel { Dock = DockStyle.Fill, ColumnCount = 1, RowCount = 6, Padding = new Padding(6) };
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F)); // name
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F)); // id
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F)); // supplier
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F)); // brand
            details.RowStyles.Add(new RowStyle(SizeType.Absolute, 28F)); // type
            details.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // spacer / extra

            var lblName = new Label { Text = _product.ProductName, Font = new Font("Segoe UI", 14F, FontStyle.Bold), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblId = new Label { Text = $"Mã: {_product.ProductId}", Font = new Font("Segoe UI", 10F), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, ForeColor = Color.Gray };

            string supplierName;
            try
            {
                var supplier = new SupplierBUS().GetAllSuppliers().Find(s => s.SupplierId == _product.SupplierId);
                supplierName = supplier?.SupplierName ?? _product.SupplierId ?? "Không xác định";
            }
            catch { supplierName = _product.SupplierId ?? "Không xác định"; }

            var lblSupplier = new Label { Text = $"Nhà cung cấp: {supplierName}", Font = new Font("Segoe UI", 10F), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

            string brandName;
            string typeName;
            try
            {
                var brand = new BrandBUS().GetAllBrands().Find(b => b.BrandId == _product.BrandId);
                var type = new TypeProductBUS().GetAllTypeProducts().Find(t => t.TypeProductId == _product.TypeId);
                brandName = brand?.BrandName ?? _product.BrandId ?? "Không xác định";
                typeName = type?.TypeProductName ?? _product.TypeId ?? "Không xác định";
            }
            catch { brandName = _product.BrandId ?? "N/A"; typeName = _product.TypeId ?? "N/A"; }

            var lblBrand = new Label { Text = $"Thương hiệu: {brandName}", Font = new Font("Segoe UI", 10F), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };
            var lblType = new Label { Text = $"Loại sản phẩm: {typeName}", Font = new Font("Segoe UI", 10F), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft };

            var lblQty = new Label { Text = $"Tồn kho: {_product.Quantity:N0}", Font = new Font("Segoe UI", 11F, FontStyle.Bold), Dock = DockStyle.Fill, TextAlign = ContentAlignment.MiddleLeft, ForeColor = _product.Quantity > 0 ? Color.Green : Color.Red };

            details.Controls.Add(lblName, 0, 0);
            details.Controls.Add(lblId, 0, 1);
            details.Controls.Add(lblSupplier, 0, 2);
            details.Controls.Add(lblBrand, 0, 3);
            details.Controls.Add(lblType, 0, 4);
            details.Controls.Add(lblQty, 0, 5);

            content.Controls.Add(imgPanel, 0, 0);
            content.Controls.Add(details, 1, 0);

            var btnClose = new Button { Text = "Đóng", Height = 40, Width = 120, BackColor = Color.FromArgb(220, 53, 69), ForeColor = Color.White, FlatStyle = FlatStyle.Flat, Font = new Font("Segoe UI", 10F, FontStyle.Bold) };
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.Click += (s, e) => Close();

            var btnPanel = new FlowLayoutPanel { Dock = DockStyle.Fill, FlowDirection = FlowDirection.RightToLeft, Padding = new Padding(8) };
            btnPanel.Controls.Add(btnClose);

            main.Controls.Add(header, 0, 0);
            main.Controls.Add(content, 0, 1);
            main.Controls.Add(btnPanel, 0, 2);

            Controls.Clear();
            Controls.Add(main);
        }

        private Image LoadProductImage(string imageName)
        {
            if (string.IsNullOrWhiteSpace(imageName))
                imageName = "DefaultProductImage.jpg";

            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string projectRoot = Directory.GetParent(basePath).Parent.Parent.Parent.FullName;
            string imagePath = Path.Combine(projectRoot, "Img", "Product", imageName);

            if (!File.Exists(imagePath))
                imagePath = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");

            if (File.Exists(imagePath))
            {
                try
                {
                    return Image.FromFile(imagePath);
                }
                catch { /* ignore */ }
            }

            return Properties.Resources.DefaultProductImage ?? null; // Nếu có ảnh default trong Resources
        }
    }
}