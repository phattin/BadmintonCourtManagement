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
    btnGenerate.Click += btnGenerate_Click;

    dateTimePicker1.Value = DateTime.Now.AddDays(-30);
    dateTimePicker2.Value = DateTime.Now;

    // ====================== CÀI ĐẶT dgTopProducts ======================
    dgTopProducts.Columns.Clear();

    // Dùng Fill để tự động chia % chiều rộng
    dgTopProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
    dgTopProducts.AllowUserToResizeColumns = false; // không cho user kéo

    dgTopProducts.Columns.Add("ProductId", "Product ID");
    dgTopProducts.Columns.Add("ProductName", "Tên Sản Phẩm");
    dgTopProducts.Columns.Add("Quantity", "Số Lượng Bán");
    dgTopProducts.Columns.Add("TotalRevenue", "Doanh Thu");

    // === TÙY CHỈNH TỶ LỆ CỘT (rất linh hoạt) ===
    dgTopProducts.Columns["ProductId"].FillWeight     = 20;  // 20%
    dgTopProducts.Columns["ProductName"].FillWeight   = 40;  // 40% → tên sản phẩm rộng nhất
    dgTopProducts.Columns["Quantity"].FillWeight      = 20;  // 20%
    dgTopProducts.Columns["TotalRevenue"].FillWeight  = 20;  // 20%

    // Nếu muốn chia đều 25% thì để tất cả FillWeight = 100 hoặc = 1 đều được
    // Ví dụ chia đều:
    // foreach (DataGridViewColumn col in dgTopProducts.Columns) col.FillWeight = 1;

    // Style đẹp
    dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Format = "C0"; // hoặc "C2" nếu muốn 2 chữ số thập phân
    dgTopProducts.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

    dgTopProducts.Columns["ProductId"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dgTopProducts.Columns["Quantity"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

    // Optional: làm đẹp thêm header
    dgTopProducts.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
    dgTopProducts.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

    

    isInitializing = false;

    SetupCourtTab();        // bạn đã sửa ở tin nhắn trước rồi đúng không?
    SetupSummaryTab();
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

    // Cho phép tự động chia cột theo tỷ lệ
    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

    // Tắt việc người dùng tự resize (nếu muốn cố định tỷ lệ)
    dataGridView1.AllowUserToResizeColumns = false;

    // Thêm các cột
    dataGridView1.Columns.Add("CourtId", "ID");
    dataGridView1.Columns.Add("CourtName", "Tên Sân");
    dataGridView1.Columns.Add("TotalRevenue", "Tổng Doanh Thu");
    dataGridView1.Columns.Add("BookingCount", "Số lần đặt sân");

    // === QUAN TRỌNG: Chia đều 25% cho mỗi cột ===
    foreach (DataGridViewColumn col in dataGridView1.Columns)
    {
        col.FillWeight = 1; // tất cả đều bằng nhau → mỗi cột 25%
        // Nếu muốn cột nào to hơn thì tăng FillWeight lên (ví dụ 1.5 → 37.5%, còn lại 20.83%)
    }

    // Căn lề và định dạng tiền
    dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Format = "C0"; // ₫ hoặc $ tùy culture
    dataGridView1.Columns["TotalRevenue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
    dataGridView1.Columns["BookingCount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

    // Có thể ẩn cột ID nếu không muốn hiển thị
    // dataGridView1.Columns["CourtId"].Visible = false;

    // Các thiết lập khác...
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

    // === HEADER ĐỒNG BỘ VỚI 2 TAB KIA (xanh đậm, bo góc) ===
    var headerPanel = new CustomPanel
    {
        Dock = DockStyle.Top,
        Height = 98,
        BackColor = Color.FromArgb(0, 120, 103),
        BorderRadius = 20
    };

    var flowFilter = new FlowLayoutPanel
    {
        Dock = DockStyle.Fill,
        FlowDirection = FlowDirection.LeftToRight,
        Padding = new Padding(35, 25, 35, 0)
    };

    // DateTimePicker
    dtpSummaryStart.Width = 300;
    dtpSummaryEnd.Width = 300;
    dtpSummaryEnd.Margin = new Padding(20, 0, 0, 0);

    // Nút Thống Kê (giữ kiểu cũ nhưng đẹp hơn)
    lblGenerateSummary = new Label
    {
        Text = "Thống Kê",
        Font = new Font("Segoe UI", 12F, FontStyle.Bold),
        ForeColor = Color.WhiteSmoke,
        BackColor = Color.FromArgb(64, 64, 64),
        TextAlign = ContentAlignment.MiddleCenter,
        Cursor = Cursors.Hand,
        AutoSize = true,
        Padding = new Padding(25, 10, 25, 10),
        Margin = new Padding(60, 0, 0, 0)
    };
    lblGenerateSummary.Click += lblGenerateSummary_Click;

    flowFilter.Controls.Add(dtpSummaryStart);
    flowFilter.Controls.Add(dtpSummaryEnd);
    flowFilter.Controls.Add(lblGenerateSummary);
    headerPanel.Controls.Add(flowFilter);

    // === BODY CHÍNH - RESPONSIVE ===
    var bodyPanel = new TableLayoutPanel
    {
        Dock = DockStyle.Fill,
        ColumnCount = 2,
        RowCount = 1,
        Padding = new Padding(30, 20, 30, 30)
    };
    bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58F));  // Biểu đồ
    bodyPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42F));  // Số liệu
    bodyPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

    // === BIỂU ĐỒ TRÒN ===
    var panelChart = new Panel
    {
        Dock = DockStyle.Fill,
        Padding = new Padding(20),
        BackColor = Color.White
    };

    chartPie = new Chart
    {
        Dock = DockStyle.Fill,
        BackColor = Color.White
    };

    var chartArea = new ChartArea();
    chartArea.Area3DStyle.Enable3D = true;
    chartArea.Area3DStyle.Rotation = 15;
    chartArea.Area3DStyle.Inclination = 15;
    chartPie.ChartAreas.Add(chartArea);

    var series = new Series("RevenueSeries")
    {
        ChartType = SeriesChartType.Pie,
        IsValueShownAsLabel = true,
        Font = new Font("Segoe UI", 11F, FontStyle.Bold),
        LabelForeColor = Color.White,
        ["PieLabelStyle"] = "Outside",
        ["PieLineColor"] = "White"
    };
    chartPie.Series.Clear();
    chartPie.Series.Add(series);

    var legend = new Legend
    {
        Docking = Docking.Right,
        Alignment = StringAlignment.Center,
        Font = new Font("Segoe UI", 11F)
    };
    chartPie.Legends.Clear();
    chartPie.Legends.Add(legend);

    panelChart.Controls.Add(chartPie);
    bodyPanel.Controls.Add(panelChart, 0, 0);

    // === BẢNG SỐ LIỆU (lớn hơn, đẹp hơn) ===
    var tableStats = new TableLayoutPanel
    {
        Dock = DockStyle.Fill,
        RowCount = 5,
        Padding = new Padding(30, 40, 30, 30),
        BackColor = Color.White
    };

    for (int i = 0; i < 5; i++)
        tableStats.RowStyles.Add(new RowStyle(SizeType.Absolute, 78F));

    // Tạo lại các label cho đẹp (dùng hàm nhỏ gọn)
    lblCourtRevenue = CreateStatLabel("Doanh thu sân bãi:");
    lblProductRevenue = CreateStatLabel("Doanh thu bán đồ:");
    lblTotalRevenue = CreateStatLabel("TỔNG DOANH THU:", true);
    lblCourtPercent = CreateStatLabel("Tỷ lệ sân bãi:");
    lblProductPercent = CreateStatLabel("Tỷ lệ bán đồ:");

    tableStats.Controls.Add(lblCourtRevenue, 0, 0);
    tableStats.Controls.Add(lblProductRevenue, 0, 1);
    tableStats.Controls.Add(lblTotalRevenue, 0, 2);
    tableStats.Controls.Add(lblCourtPercent, 0, 3);
    tableStats.Controls.Add(lblProductPercent, 0, 4);

    bodyPanel.Controls.Add(tableStats, 1, 0);

    // === GỘP TẤT CẢ VÀO CUSTOM PANEL ===
    customPanelSummary.Controls.Clear();
    customPanelSummary.BackColor = Color.FromArgb(239, 248, 230);
    customPanelSummary.BorderRadius = 20;
    customPanelSummary.Dock = DockStyle.Fill;
    customPanelSummary.Padding = new Padding(70, 84, 70, 50); // Đồng bộ với 2 tab kia

    customPanelSummary.Controls.Add(bodyPanel);
    customPanelSummary.Controls.Add(headerPanel); // Header ở trên cùng

    // Chỉ load khi bấm nút (không tự động khi đổi ngày)
    // LoadRevenueSummary(); // Bỏ dòng này nếu không muốn load lần đầu
}

// Hàm tạo label thống kê đẹp, gọn
private Label CreateStatLabel(string text, bool isTotal = false)
{
    return new Label
    {
        Text = isTotal ? $"{text} 0₫" : $"{text} 0₫",
        Font = new Font("Segoe UI", isTotal ? 16F : 13F, isTotal ? FontStyle.Bold : FontStyle.Regular),
        ForeColor = isTotal ? Color.FromArgb(0, 120, 103) : Color.FromArgb(50, 50, 50),
        Dock = DockStyle.Fill,
        TextAlign = ContentAlignment.MiddleLeft,
        Padding = new Padding(10, 8, 0, 8),
        AutoSize = false
    };
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
        // private void dateTimePicker1_ValueChanged(object sender, EventArgs e) { }
        // private void dateTimePicker2_ValueChanged(object sender, EventArgs e) { }
        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e) { }
        private void customPanel1_Paint(object sender, PaintEventArgs e) { }
        private void customPanel10_Paint(object sender, PaintEventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) { if (!isInitializing) label4_Click(sender, e); }
        private void dateTimePicker4_ValueChanged(object sender, EventArgs e) { if (!isInitializing) label4_Click(sender, e); }
    }
}