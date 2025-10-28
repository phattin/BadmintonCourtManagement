﻿using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class ProductGUI : UserControl
    {
        private ProductFilterGUI filter; // AI Generated Code
        private List<ProductDTO> productList;
        private int page = 0;
        private int itemPerPage = 8;

        public ProductGUI(AccountDTO currentAccount)
        {
            InitializeComponent();
            productList = new List<ProductDTO>();
            ProductBUS productBUS = new ProductBUS();
            productList = productBUS.GetAllProducts();
            LoadProducts(productList);
            searchBar.KeyDown += searchEnterEvent;
        }
        // private void SetupFilter(ProductFilterGUI filter)
        // {
        //     var brands = LoadBrands();
        //     var types = LoadTypes();
        //     // MessageBox.Show(brands[0].ToString());
        //     // MessageBox.Show(types[0].ToString());
        //     filter.InsertData(brands, types);
        // }

        private List<BrandDTO> LoadBrands()
        {
            BrandBUS brandBus = new BrandBUS();
            return brandBus.GetAllBrands();
        }


        private List<TypeProductDTO> LoadTypes()
        {
            TypeProductBUS typeBus = new TypeProductBUS();
            return typeBus.GetAllTypeProducts();
        }

        private void LoadProducts(List<ProductDTO> productList)
        {
            // Dispose old images before clearing
            foreach (Control ctrl in pProductList.Controls)
            {
                if (ctrl is CustomPanel panel)
                {
                    foreach (Control child in panel.Controls)
                    {
                        if (child is TableLayoutPanel tlp)
                        {
                            foreach (Control innerCtrl in tlp.Controls)
                            {
                                if (innerCtrl is PictureBox pb)
                                {
                                    pb.Image?.Dispose();
                                }
                            }
                        }
                    }
                }
                ctrl.Dispose();
            }

            int panelWidth = pProductList.Width;
            int panelHeight = pProductList.Height;
            pProductList.Controls.Clear();
            pProductList.ColumnStyles.Clear();
            pProductList.RowStyles.Clear();
            // int columns = panelWidth / 200;
            // int rows = panelHeight / 280;
            int columns = 4; // Số cột cố định
            int rows = 2;    // Số hàng cố định

            for (int i = 0; i < columns; i++)
                pProductList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < rows; j++)
                pProductList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int index = page * itemPerPage;
            /*
                        foreach (ProductDTO productDTO in productList)
                        {
                            var panel = CreateProductPanel(productDTO);
                            int row = index / 4;
                            int col = index % 4;
                            pProductList.Controls.Add(panel, col, row);
                            index++;
                        }
            */
            for (int i = index; i < index + itemPerPage; i++)
            {
                if (i < productList.Count && i >= 0)
                {
                    var panel = CreateProductPanel(productList[i]);
                    int row = (i - index) / 4;  // FIXED: was using index instead of (i - index)
                    int col = (i - index) % 4;  // FIXED: was using index instead of (i - index)
                    pProductList.Controls.Add(panel, col, row);
                }
            }
        }

        private CustomPanel CreateProductPanel(ProductDTO productDTO)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 250, 214),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tlProduct = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 4 // Thông tin: Id, Img, Name, Nút
            };

            tlProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Mã sản phẩm
            tlProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 65F));  // Ảnh sản phẩm
            tlProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));  // Tên sản phẩm
            tlProduct.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));  // Nút

            // Label mã sản phẩm
            var lblID = new Label
            {
                Text = productDTO.ProductId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ===== AI Generated =====

            var pictureBox = new PictureBox
            {
                // Image = (Image)resizedImage ?? productImage,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                Margin = new Padding(10),
                Size = new Size(300, 300)
            };

            try
            {
                // string imageFileName = productDTO.ProductImg;
                string imageFileName = "DefaultProductImage.jpg";                
                string imagePath = string.Concat("Img\\Product\\", imageFileName);

                // MessageBox.Show(productDTO.ProductImg);
                // MessageBox.Show(imagePath);

                if (File.Exists(imagePath))
                {
                    using (var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        using (Image original = Image.FromStream(fs))
                        {
                            // Create a completely independent bitmap copy
                            var resized = new Bitmap(300, 300);
                            using (var graphics = Graphics.FromImage(resized))
                            {
                                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                graphics.DrawImage(original, 0, 0, 300, 300);
                            }
                            pictureBox.Image = resized;
                        }

                    }
                }
                else
                {
                    string defaultPath = "Img\\Product\\DefaultProductImage.jpg";
                    // string defaultPath = Path.Combine(Application.StartupPath, "Img", "Product", "DefaultProductImage.jpg");
                    if (File.Exists(defaultPath))
                    {
                        using (var fs = new FileStream(defaultPath, FileMode.Open, FileAccess.Read))
                        {
                            using (Image original = Image.FromStream(fs))
                            {
                                var resized = new Bitmap(300, 300);
                                using (var graphics = Graphics.FromImage(resized))
                                {
                                    graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                                    graphics.DrawImage(original, 0, 0, 300, 300);
                                }
                                pictureBox.Image = resized;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


            // Image productImage;
            // try
            // {
            //     productImage = Image.FromFile(imagePath);
            // }
            // catch (Exception ex)
            // // check if productImage is null
            // {
            //     // productImage = Image.FromFile(Application.StartupPath + @"\Img\Product\DefaultProductImage.jpg");
            //     productImage = Image.FromFile("Img\\Product\\DefaultProductImage.jpg");
            //     throw new Exception(ex.Message);
            // }

            // Bitmap resizedImage = new Bitmap(productImage, new Size(300, 300));


            // ===== AI Generated =====

            // Label tên sản phẩm
            var lblName = new Label
            {
                Text = productDTO.ProductName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 15, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Panel chứa hai nút
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Padding = new Padding(0, 5, 0, 5),
                Margin = new Padding(0),
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // Nút Chi tiết
            var btnDetail = new Button
            {
                Text = "Chi tiết",
                Width = 100,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            // Nút Sửa
            var btnEdit = new Button
            {
                Text = "Sửa",
                Width = 70,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            // Sự kiện Detail
            // btnDetail.Click += (s, e) =>
            // {
            //     Form detailForm = new Form()
            //     {
            //         Text = "Chi tiết sản phẩm",
            //         Size = new Size(400, 300),
            //         StartPosition = FormStartPosition.CenterParent
            //     };

            //     var lblDetail = new Label()
            //     {
            //         Text = $"Mã sản phẩm: {courtDTO.CourtId}\nTên sản phẩm: {courtDTO.CourtName}",
            //         Dock = DockStyle.Fill,
            //         Font = new Font("Segoe UI", 12, FontStyle.Regular),
            //         TextAlign = ContentAlignment.MiddleCenter
            //     };

            //     detailForm.Controls.Add(lblDetail);
            //     detailForm.ShowDialog();
            // };

            // Sự kiện Sửa
            // btnEdit.Click += (s, e) =>
            // {
            //     Form dialog = new Form()
            //     {
            //         Text = string.Empty, // bỏ tiêu đề
            //         FormBorderStyle = FormBorderStyle.FixedDialog,
            //         StartPosition = FormStartPosition.CenterParent,
            //         Size = new Size(450, 450),
            //         MaximizeBox = false,
            //         MinimizeBox = false,
            //         ShowInTaskbar = false
            //     };

            //     var editCourtGUI = new EditCourtGUI(courtDTO);
            //     editCourtGUI.Dock = DockStyle.Fill;

            //     dialog.Controls.Add(editCourtGUI);

            //     dialog.ShowDialog();

            //     ReloadCourtList(); // reload danh sách sau khi đóng dialog
            // };


            buttonPanel.Controls.Add(btnDetail);
            buttonPanel.Controls.Add(btnEdit);

            // Thêm tất cả control vào TableLayoutPanel
            tlProduct.Controls.Add(lblID, 0, 0);
            tlProduct.Controls.Add(pictureBox, 0, 1);
            tlProduct.Controls.Add(lblName, 0, 2);
            tlProduct.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tlProduct);

            return panel;
        }

        // Pagination buttons
        private void previousButton_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0) page = 0;
            LoadProducts(productList);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            page++;
            if (page > (int)Math.Ceiling((double)productList.Count() / 8) - 1)
                page = (int)Math.Ceiling((double)productList.Count() / 8) - 1;
            LoadProducts(productList);
        }

        private void extraPreviousButton_Click(object sender, EventArgs e)
        {
            page = 0;
            LoadProducts(productList);
        }

        private void extraNextButton_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)productList.Count() / 8) - 1;
            if (page < 0) page = 0;
            LoadProducts(productList);
        }

        // Search function
        private void searchEnterEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(searchBar.Text.ToString());
            }
        }

        private void search(string text)
        {
            try
            {
                ProductBUS productBus = new ProductBUS();
                productList = productBus.GetProductByName(text);
                LoadProducts(productList);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message + "\n",
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            searchBar.Clear();
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
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

        private void filterButton_Click(object sender, EventArgs e)
        {
            var brands = LoadBrands();
            var types = LoadTypes();
            Form dialog = new Form()
            {
                Text = string.Empty,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(600, 600),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var filterForm = new ProductFilterGUI { Dock = DockStyle.Fill };
            filterForm.InsertData(brands, types);
            filterForm.FilterApplied += criteria =>
            {
                ProductBUS productBus = new ProductBUS();
                // Empty criteria => load all
                if (string.IsNullOrWhiteSpace(criteria.BrandIds)
                    && string.IsNullOrWhiteSpace(criteria.TypeIds)
                    && !criteria.OnlyStock)
                {
                    productList = productBus.GetAllProducts();
                    page = 0;
                    LoadProducts(productList);
                    return;
                }

                productList = productBus.GetProductByIds(criteria.BrandIds, criteria.TypeIds, criteria.OnlyStock);
                page = 0;
                LoadProducts(productList);
            };

            dialog.Controls.Add(filterForm);
            dialog.ShowDialog();
        }
    }
}
