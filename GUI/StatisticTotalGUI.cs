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
using System.Windows.Forms.DataVisualization.Charting;

namespace GUI
{
    public partial class StatisticTotalGUI : UserControl
    {
        public StatisticTotalGUI()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            LoadFinancialReport();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            LoadFinancialReport();
        }

        private void LoadFinancialReport()
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }

            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;

            BillBookingBUS billBookingBUS = new BillBookingBUS();
            var listBillBooking = billBookingBUS.GetAllBillBookings();
            BillProductBUS billProductBUS = new BillProductBUS();
            var listBillProduct = billProductBUS.GetAllProductBills();
            BillImportBUS importBillBUS = new BillImportBUS();
            var listImportBill = importBillBUS.GetAllImportBills();

            double totalBooking = listBillBooking
                .Where(x => x.DateCreated.Date >= fromDate && x.DateCreated.Date <= toDate)
                .Sum(x => x.TotalPrice);

            double totalSales = listBillProduct
                .Where(x => (x.Status == BillProductDTO.Option.paid) &&
                            x.DateCreated.Date >= fromDate &&
                            x.DateCreated.Date <= toDate)
                .Sum(x => x.TotalPrice);

            double totalImport = listImportBill
                .Where(x => (x.Status == ImportBillDTO.Option.paid) &&
                            x.DateCreated.Date >= fromDate && 
                            x.DateCreated.Date <= toDate)
                .Sum(x => x.TotalPrice);

            double totalRevenue = totalBooking + totalSales;
            double profit = totalRevenue - totalImport;

            label3.Text = totalBooking.ToString("N0") + " VNĐ";
            label4.Text = totalSales.ToString("N0") + " VNĐ";
            label6.Text = totalRevenue.ToString("N0") + " VNĐ";
            label6.ForeColor = Color.Blue;
            label8.Text = totalImport.ToString("N0") + " VNĐ";
            label8.ForeColor = Color.OrangeRed;
            label10.Text = profit.ToString("N0") + " VNĐ";
            label10.Font = new Font(label10.Font, FontStyle.Bold);

            if (profit > 0) label10.ForeColor = Color.Green;
            else if (profit < 0) label10.ForeColor = Color.Red;
            else label10.ForeColor = Color.Black;

            DrawFinancialPieChart(totalBooking, totalSales);
        }

        private void DrawFinancialPieChart(double bookingRevenue, double salesRevenue)
        {
            var series = chartFinancial.Series["SeriesPhanTram"];
            series.Points.Clear();

            if (bookingRevenue == 0 && salesRevenue == 0)
            {
                chartFinancial.Titles[0].Text = "Chưa có dữ liệu doanh thu";
                return;
            }
            else
            {
                chartFinancial.Titles[0].Text = "Tỷ trọng Doanh thu";
            }

            // --- Phần Đặt sân ---
            int i1 = series.Points.AddXY("Đặt sân", bookingRevenue);
            series.Points[i1].Color = Color.CornflowerBlue;
            series.Points[i1].LegendText = $"Đặt sân: {bookingRevenue:N0} VND";

            // --- Phần Bán hàng ---
            int i2 = series.Points.AddXY("Bán hàng", salesRevenue);
            series.Points[i2].Color = Color.OrangeRed;
            series.Points[i2].LegendText = $"Bán hàng: {salesRevenue:N0} VND";
        }
    }
}
