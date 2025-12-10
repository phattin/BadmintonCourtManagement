using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DAO;
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
    public partial class StatisticBookingGUI : UserControl
    {
        public StatisticBookingGUI()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            LoadStatisticBookingData();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            LoadStatisticBookingData();
        }

        private void LoadStatisticBookingData()
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            BookingBUS bookingBUS = new BookingBUS();
            var listBooking = bookingBUS.GetAllBookings();
            BillBookingBUS billBookingBUS = new BillBookingBUS();
            var listBills = billBookingBUS.GetAllBillBookings();
            CourtBUS courtBUS = new CourtBUS();
            var listCourts = courtBUS.GetAllCourts();

            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;

            //Join: Nối hai bảng Booking và BillBooking dựa trên BookingId
            var statisticResult = listBooking
                .Where(b =>
                    b.Status == BookingDTO.Option.successful &&
                    b.StartTime.Date >= fromDate &&
                    b.StartTime.Date <= toDate
                )
                // --- JOIN 1: Booking + Bill (Lấy tiền) ---
                .Join(listBills,
                        booking => booking.BookingId,
                        bill => bill.BookingId,
                        (booking, bill) => new
                        {
                            booking.CourtId,
                            bill.TotalPrice
                        })
                // --- JOIN 2: Kết quả trên + Court (Lấy tên sân) ---
                .Join(listCourts,
                        temp => temp.CourtId,       
                        court => court.CourtId,    
                        (temp, court) => new
                        {
                            court.CourtName,        
                            temp.TotalPrice,        
                            court.CourtId           
                        })
                .GroupBy(x => new { x.CourtId, x.CourtName })
                .Select(g => new
                {
                    MaSan = g.Key.CourtId,      
                    TenSan = g.Key.CourtName,
                    TongSoLanDat = g.Count(),
                    TongTien = g.Sum(x => x.TotalPrice)
                })
                .OrderBy(x => x.MaSan)
                .ToList();

            dataGridView1.DataSource = statisticResult;
            DrawChart(statisticResult);
            chartStatistic.Visible = true;
        }

        private void DrawChart(System.Collections.IList data)
        {
            var seriesTien = chartStatistic.Series["SeriesDoanhThu"];
            var seriesSoLuong = chartStatistic.Series["SeriesSoLuong"];

            seriesTien.Points.Clear();
            seriesSoLuong.Points.Clear();

            foreach (dynamic item in data)
            {
                seriesTien.Points.AddXY(item.TenSan, item.TongTien);
                seriesSoLuong.Points.AddXY(item.TenSan, item.TongSoLanDat);
            }
            var chartArea = chartStatistic.ChartAreas[0];

            int viewSize = 5;
            if (data.Count > viewSize)
            {
                chartArea.AxisX.ScaleView.Zoom(0, viewSize); 
                chartArea.AxisX.ScrollBar.IsPositionedInside = false; 
            }
            else
            {
                chartArea.AxisX.ScaleView.ZoomReset();
            }
        }
    }
}
