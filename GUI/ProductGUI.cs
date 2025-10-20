using BadmintonCourtManagement.BUS;
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
    public partial class ProductGUI : UserControl
    {
        public ProductGUI(AccountDTO currentAccount)
        {
            InitializeComponent();
            List<ProductDTO> products = new List<ProductDTO>();
            ProductBUS productBUS = new ProductBUS();
            products = productBUS.GetAllProducts();
            LoadProducts(products);
        }

        private void LoadProducts(List<ProductDTO> products)
        {
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

            int index = 0;
            foreach (ProductDTO productDTO in products)
            {
                var panel = CreateProductPanel(productDTO);
                int row = index / 4;
                int col = index % 4;
                pProductList.Controls.Add(panel, col, row);
                index++;
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

            string imageFileName = string.IsNullOrWhiteSpace(productDTO.ProductImg) ? 
                "DefaultProductImage.jpg" : productDTO.ProductImg;
            string imagePath = string.Concat("Resources\\Img\\Product\\", imageFileName);

            // MessageBox.Show(productDTO.ProductImg);
            // MessageBox.Show(imagePath);
            Image productImage;
            try
            {
                if (System.IO.File.Exists(imagePath))
                {
                    productImage = Image.FromFile(imagePath);
                }
                else
                {
                    // Fallback to embedded resource
                    productImage = Image.FromFile(Application.StartupPath + @"\Img\Product\DefaultProductImage.jpg");
                }
            }
            catch (Exception)
            {
                // Double fallback in case of any file loading issues
                productImage = Image.FromFile(Application.StartupPath + @"\Img\Product\DefaultProductImage.jpg");
            }
            // check if productImage is null
            {
                productImage = Image.FromFile(Application.StartupPath + @"\Img\Product\DefaultProductImage.jpg");
            }

            Bitmap resizedImage = new Bitmap(productImage, new Size(300, 300));

            var pictureBox = new PictureBox
            {
                Image = (Image)resizedImage ?? productImage,
                SizeMode = PictureBoxSizeMode.Zoom,
                Dock = DockStyle.Top,
                Margin = new Padding(10),
                Size = new Size(300, 300)
            };

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

        private void storageGUI_Load(object sender, EventArgs e)
        {

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

        private void textBox1_TextChanged(object sender, EventArgs e)
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

        private void cardButton_Click(object sender, EventArgs e)
        {
            EmployeeDetailsGUI employeeDetail = new EmployeeDetailsGUI();
            employeeDetail.ShowDialog();
        }

        private void cardTitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhapHangFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangButtonCard_Click(object sender, EventArgs e)
        {
            SupplyDetailsGUI supplyDetails = new SupplyDetailsGUI();
            supplyDetails.ShowDialog();
        }

        private void NhapHangBodyCard_Click(object sender, EventArgs e)
        {

        }

        private void cardBody_Click(object sender, EventArgs e)
        {

        }

        private void cardButton_Click_1(object sender, EventArgs e)
        {
            EmployeeDetailsGUI employeeDetails = new EmployeeDetailsGUI();
            employeeDetails.ShowDialog();
        }
    }
}
