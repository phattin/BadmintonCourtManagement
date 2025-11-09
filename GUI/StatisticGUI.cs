using System;
using System.Collections.Generic;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.DAO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing;
using System.Linq;

namespace BadmintonCourtManagement.GUI
{
    public partial class StatisticGUI : UserControl
    {
        private AccountDTO currentAccount;
        private StatisticalBUS statisticalBUS;
        private bool isInitializing = true;

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
            dateTimePicker1.Value = DateTime.Now.AddDays(-30);
            dateTimePicker2.Value = DateTime.Now;

            dgTopProducts.Columns.Clear();
            dgTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dgTopProducts.AllowUserToResizeColumns = false;

            dgTopProducts.Columns.Add("ProductId", "Product ID");
            dgTopProducts.Columns.Add("ProductName", "Product Name");
            dgTopProducts.Columns.Add("Quantity", "Total Sold");
            dgTopProducts.Columns.Add("TotalRevenue", "Total Revenue");

            dgTopProducts.Columns["ProductId"].Width = 370;
            dgTopProducts.Columns["ProductName"].Width = 380;
            dgTopProducts.Columns["Quantity"].Width = 370;
            dgTopProducts.Columns["TotalRevenue"].Width = 367;

            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Format = "C2";
            dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgTopProducts.Columns["ProductId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgTopProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            isInitializing = false;

            SetupCourtTab();
            SetupSummaryTab(); // Tạo layout động tại đây
            
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            DateTime startDate = dateTimePicker1.Value;
            DateTime endDate = dateTimePicker2.Value;

            string selectedOption = sortFieldComboBox.SelectedItem?.ToString() ?? "Số lượng sản phẩm giảm dần";
            string sortBy = "TotalSold";
            bool sortDescending = true;

            switch (selectedOption)
            {
                case "Số lượng sản phẩm giảm dần": sortBy = "TotalSold"; sortDescending = true; break;
                case "Số lượng sản phẩm tăng dần": sortBy = "TotalSold"; sortDescending = false; break;
                case "Doanh thu tăng dần": sortBy = "TotalRevenue"; sortDescending = false; break;
                case "Doanh thu giảm dần": sortBy = "TotalRevenue"; sortDescending = true; break;
            }

            try
            {
                if (startDate > endDate)
                {
                    MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var products = statisticalBUS.GetTopSellingProducts(startDate, endDate, sortDescending, sortBy);
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

        private void SetupCourtTab()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.AllowUserToResizeColumns = false;

            dataGridView1.Columns.Add("CourtId", "ID");
            dataGridView1.Columns.Add("CourtName", "Tên Sân");
            dataGridView1.Columns.Add("TotalRevenue", "Tổng Doanh Thu");
            dataGridView1.Columns.Add("BookingCount", "Số lần đặt sân");

            dataGridView1.Columns["CourtId"].Width = 250;
            dataGridView1.Columns["CourtName"].Width = 400;
            dataGridView1.Columns["TotalRevenue"].Width = 400;
            dataGridView1.Columns["BookingCount"].Width = 387;

            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Format = "C0";
            dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridView1.Columns["BookingCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            // dataGridView1.Columns["CourtId"].Visible = false;

            label4.Click += label4_Click;

            dateTimePicker3.Value = DateTime.Now.AddDays(-30);
            dateTimePicker4.Value = DateTime.Now;
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

            string courtNameFilter = textBox1.Text.Trim();
            bool sortDescending = true;

            try
            {
                var revenueData = statisticalBUS.GetCourtRevenue(startDate, endDate, courtNameFilter, sortDescending);
                dataGridView1.Rows.Clear();
                foreach (var item in revenueData)
                {
                    dataGridView1.Rows.Add(item.CourtId, item.CourtName, item.TotalRevenue, item.BookingCount);
                }

                if (revenueData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu trong khoảng thời gian đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu sân: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetupSummaryTab()
        {
            dtpSummaryStart.Value = DateTime.Now.AddDays(-30);
            dtpSummaryEnd.Value = DateTime.Now;

            TableLayoutPanel tableMain = new TableLayoutPanel();
            tableMain.Dock = DockStyle.Fill;
            tableMain.ColumnCount = 2;
            tableMain.RowCount = 2;
            tableMain.Size = new Size(1200, 600); // Set an initial size
            
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            tableMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            // Filter
            FlowLayoutPanel flowFilter = new FlowLayoutPanel();
            flowFilter.Dock = DockStyle.Fill;
            flowFilter.FlowDirection = FlowDirection.LeftToRight;
            flowFilter.Padding = new Padding(10, 20, 10, 10);

            dtpSummaryStart.Width = 280;
            dtpSummaryStart.Margin = new Padding(0, 0, 15, 0);
            dtpSummaryEnd.Width = 280;
            dtpSummaryEnd.Margin = new Padding(0, 0, 30, 0);

            lblGenerateSummary.Text = "Thống Kê";
            lblGenerateSummary.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            lblGenerateSummary.ForeColor = Color.WhiteSmoke;
            lblGenerateSummary.BackColor = Color.FromArgb(64, 64, 64);
            lblGenerateSummary.TextAlign = ContentAlignment.MiddleCenter;
            lblGenerateSummary.Cursor = Cursors.Hand;
            lblGenerateSummary.AutoSize = false;
            lblGenerateSummary.Width = 130;
            lblGenerateSummary.Height = 36;
            lblGenerateSummary.Margin = new Padding(10, 10, 0, 0);
            lblGenerateSummary.Padding = new Padding(10, 0, 10, 0);

            flowFilter.Controls.Add(dtpSummaryStart);
            flowFilter.Controls.Add(dtpSummaryEnd);
            flowFilter.Controls.Add(lblGenerateSummary);

            tableMain.Controls.Add(flowFilter, 0, 0);
            tableMain.SetColumnSpan(flowFilter, 2);

            // Chart
            Panel panelChart = new Panel();
            panelChart.Dock = DockStyle.Fill;
            panelChart.Padding = new Padding(20);
            panelChart.MinimumSize = new Size(100, 100); // Set minimum size
            
            chartPie.BackColor = Color.White;
            chartPie.Dock = DockStyle.Fill;
            chartPie.MinimumSize = new Size(100, 100); // Set minimum size for chart

            var chartArea = new ChartArea("ChartArea");
            chartPie.ChartAreas.Add(chartArea);

            var series = new Series("RevenueSeries");
            series.ChartType = SeriesChartType.Pie;
            series.IsValueShownAsLabel = true;
            series["PieLabelStyle"] = "Outside";
            chartPie.Series.Add(series);

            var legend = new Legend("Legend");
            legend.Docking = Docking.Right;
            chartPie.Legends.Add(legend);

            panelChart.Controls.Add(chartPie);
            tableMain.Controls.Add(panelChart, 0, 1);

            // Stats
            TableLayoutPanel tableStats = new TableLayoutPanel();
            tableStats.Dock = DockStyle.Fill;
            tableStats.RowCount = 5;
            tableStats.Padding = new Padding(20, 40, 20, 20);
            tableStats.AutoScroll = true;

            for (int i = 0; i < 5; i++)
                tableStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 55F));

            tableStats.Controls.Add(lblCourtRevenue, 0, 0);
            tableStats.Controls.Add(lblProductRevenue, 0, 1);
            tableStats.Controls.Add(lblTotalRevenue, 0, 2);
            tableStats.Controls.Add(lblCourtPercent, 0, 3);
            tableStats.Controls.Add(lblProductPercent, 0, 4);

            tableMain.Controls.Add(tableStats, 1, 1);

            customPanelSummary.Controls.Clear();
            customPanelSummary.Controls.Add(tableMain);

            lblGenerateSummary.Click += lblGenerateSummary_Click;
            dtpSummaryStart.ValueChanged += (s, e) => { if (!isInitializing) LoadRevenueSummary(); };
            dtpSummaryEnd.ValueChanged += (s, e) => { if (!isInitializing) LoadRevenueSummary(); };

            LoadRevenueSummary();
        }

        private void LoadRevenueSummary()
        {
            DateTime start = dtpSummaryStart.Value.Date;
            DateTime end = dtpSummaryEnd.Value.Date;

            if (start > end)
            {
                MessageBox.Show("Ngày bắt đầu phải nhỏ hơn hoặc bằng ngày kết thúc.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var summary = statisticalBUS.GetRevenueSummary(start, end);

                lblCourtRevenue.Text = $"Doanh thu sân: {summary.CourtRevenue:C0}";
                lblProductRevenue.Text = $"Doanh thu bán đồ: {summary.ProductRevenue:C0}";
                lblTotalRevenue.Text = $"Tổng doanh thu: {summary.TotalRevenue:C0}";
                lblCourtPercent.Text = $"Tỷ lệ sân: {summary.CourtPercentage}%";
                lblProductPercent.Text = $"Tỷ lệ đồ: {summary.ProductPercentage}%";

                chartPie.Series["RevenueSeries"].Points.Clear();
                if (summary.TotalRevenue > 0)
                {
                    chartPie.Series["RevenueSeries"].Points.AddXY("Sân", summary.CourtRevenue);
                    chartPie.Series["RevenueSeries"].Points.AddXY("Bán đồ", summary.ProductRevenue);
                    chartPie.Series["RevenueSeries"].Points[0].Label = $"{summary.CourtPercentage}%";
                    chartPie.Series["RevenueSeries"].Points[1].Label = $"{summary.ProductPercentage}%";
                }
                else
                {
                    chartPie.Series["RevenueSeries"].Points.AddXY("Không có dữ liệu", 1);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblGenerateSummary_Click(object? sender, EventArgs e) => LoadRevenueSummary();

        // Các sự kiện trống
        private void sortFieldComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e) { }
        private void customPanel1_Paint(object sender, PaintEventArgs e) { }
        private void customPanel10_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) { if (!isInitializing) label4_Click(sender, e); }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e) { if (!isInitializing) label4_Click(sender, e); }
    }
}