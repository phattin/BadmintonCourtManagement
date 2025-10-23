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
            dgTopProducts.Columns["ProductId"].Width = 392;
            dgTopProducts.Columns["ProductName"].Width = 391;
            dgTopProducts.Columns["Quantity"].Width = 390;
            dgTopProducts.Columns["TotalRevenue"].Width = 392;

            // Optional: format revenue column
            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Format = "C2"; // Currency format
            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            // Optional: center-align other columns
            dgTopProducts.Columns["ProductId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTopProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Do not fetch initial data here to avoid automatic refresh
            isInitializing = false; // Allow button clicks to work after initialization
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
    }
}