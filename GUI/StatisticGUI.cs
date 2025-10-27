using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;

namespace BadmintonCourtManagement.GUI
{
    public partial class StatisticGUI : UserControl
    {
        private AccountDTO currentAccount;
        private StatisticalBUS statisticalBUS;
        private bool isInitializing = true; // Flag to prevent auto-refresh during initialization

        public StatisticGUI()
        {
            InitializeComponent();
        }

        public StatisticGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            statisticalBUS = new StatisticalBUS();

            // Thiết lập cho tab Sân
            SetupCourtTab();
        }

        private void StatisticGUI_Load(object sender, EventArgs e)
        {
            // Set default date range (e.g., last 30 days)
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            dateTimePicker2.Value = DateTime.Now;

            // Initialize DataGridView columns
            dgTopProducts.Columns.Clear();
            dgTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None; // Disable auto size for manual width
            dgTopProducts.AllowUserToResizeColumns = false;

            dgTopProducts.Columns.Add("ProductId", "Product ID");
            dgTopProducts.Columns.Add("ProductName", "Product Name");
            dgTopProducts.Columns.Add("Quantity", "Total Sold");
            dgTopProducts.Columns.Add("TotalRevenue", "Total Revenue");

            // Format and set widths
            dgTopProducts.Columns["ProductId"].Width = 370;
            dgTopProducts.Columns["ProductName"].Width = 380;
            dgTopProducts.Columns["Quantity"].Width = 370;
            dgTopProducts.Columns["TotalRevenue"].Width = 367;

            // Optional: format revenue column
            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Format = "C2"; // Currency format
            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Optional: center-align other columns
            dgTopProducts.Columns["ProductId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTopProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Do not fetch initial data here to avoid automatic refresh

            isInitializing = false; // Allow button clicks to work after initialization

            // Khởi tạo tab Sân
            SetupCourtTab();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Get date range
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            // Get sort options from ComboBox
            string selectedOption = sortFieldComboBox.SelectedItem?.ToString() ?? "Số lượng sản phẩm giảm dần";
            string sortBy = "TotalSold";
            bool sortDescending = true;

            switch (selectedOption)
            {
                case "Số lượng sản phẩm giảm dần":
                    sortBy = "TotalSold";
                    sortDescending = true;
                    break;
                case "Số lượng sản phẩm tăng dần":
                    sortBy = "TotalSold";
                    sortDescending = false;
                    break;
                case "Doanh thu tăng dần":
                    sortBy = "TotalRevenue";
                    sortDescending = false;
                    break;
                case "Doanh thu giảm dần":
                    sortBy = "TotalRevenue";
                    sortDescending = true;
                    break;
            }

            try
            {
                // Validate date range
                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch data
                List<StatisticalDAO.TopSellingProductDTO> products = statisticalBUS.GetTopSellingProducts(startDate, endDate, sortDescending, sortBy);

                // Populate DataGridView
                dgTopProducts.Rows.Clear();
                foreach (var product in products)
                {
                    dgTopProducts.Rows.Add(product.ProductId, product.ProductName, product.Quantity, product.TotalRevenue);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo báo cáo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Thêm vào cuối constructor hoặc sau InitializeComponent()

        private void SetupCourtTab()
        {
            // Thiết lập cột cho dataGridView1
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.Columns.Add("CourtName", "Tên Sân");
            dataGridView1.Columns.Add("TotalBookings", "Số Lượt Đặt");
            dataGridView1.Columns.Add("TotalRevenue", "Tổng Doanh Thu");
            dataGridView1.Columns.Add("AverageRevenue", "Doanh Thu Trung Bình");

            // Định dạng cột
            dataGridView1.Columns["CourtName"].Width = 400;
            dataGridView1.Columns["TotalBookings"].Width = 300;
            dataGridView1.Columns["TotalRevenue"].Width = 400;
            dataGridView1.Columns["AverageRevenue"].Width = 387;

            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["AverageRevenue"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["AverageRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["TotalBookings"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Gán sự kiện Click cho label4 (nút Thống Kê ở tab Sân)
            label4.Click += label4_Click;

            // Tải danh sách sân vào comboBox1 (nếu cần lọc)
            LoadCourtNames();

            // Đặt giá trị mặc định cho dateTimePicker
            dateTimePicker3.Value = DateTime.Now.AddDays(-30);
            dateTimePicker4.Value = DateTime.Now;
        }

        private void LoadCourtNames()
        {
            try
            {
                var courts = statisticalBUS.GetCourtRevenue(DateTime.Today.AddDays(-365), DateTime.Today, "", false);
                var courtNames = courts.Select(c => c.CourtName).Distinct().OrderBy(n => n).ToList();
                textBox1.Text = "";
            }
            catch
            {
                textBox1.Text = "";
            }
        }


        // Remove automatic refresh from these event handlers
        private void sortFieldComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // No action needed; data will only refresh when the button is clicked
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // No action needed; data will only refresh when the button is clicked
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            // No action needed; data will only refresh when the button is clicked
        }

        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker3.Value.Date;
            DateTime endDate = dateTimePicker4.Value.Date;

            if (startDate > endDate)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string courtNameFilter = textBox1.Text?.ToString() ?? "";
            if (courtNameFilter == "")
                courtNameFilter = "";

            bool sortDescending = true; // Có thể mở rộng thêm tùy chọn sắp xếp sau

            try
            {
                var revenueData = statisticalBUS.GetCourtRevenue(startDate, endDate, courtNameFilter, sortDescending);

                dataGridView1.Rows.Clear();
                foreach (var item in revenueData)
                {
                    dataGridView1.Rows.Add(
                        item.CourtId,
                        item.CourtName,
                        item.TotalRevenue,
                        item.AverageRevenue

                    );
                }

                if (revenueData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu sân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon

        .Error);
            }
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {
            if (!isInitializing) label4_Click(sender, e);
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {
            if (!isInitializing) label4_Click(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isInitializing) label4_Click(sender, e);
        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void sortFieldComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void customPanel10_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}