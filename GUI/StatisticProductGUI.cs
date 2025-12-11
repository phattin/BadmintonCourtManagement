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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace GUI
{
    public partial class StatisticProductGUI : UserControl
    {
        private System.Collections.IList originalData;
        public StatisticProductGUI()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            LoadStatisticProductData();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            LoadStatisticProductData();
        }

        private void LoadStatisticProductData()
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }

            BillProductBUS billProductBUS = new BillProductBUS();
            var listBillProducts = billProductBUS.GetAllProductBills();
            BillProductDetailBUS billDetailBUS = new BillProductDetailBUS();
            var listBillDetails = billDetailBUS.GetAllDetailProductBills();
            ProductBUS productBUS = new ProductBUS();
            var listProducts = productBUS.GetAllProducts();

            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;

            var statisticResult = listBillProducts
                .Where(b =>
                    (b.Status == BillProductDTO.Option.paid) &&
                    b.DateCreated.Date >= fromDate &&
                    b.DateCreated.Date <= toDate
                )
                // JOIN 1: Nối với chi tiết hóa đơn để lấy sản phẩm đã bán
                .Join(listBillDetails,
                        bill => bill.BillProductId,
                        detail => detail.BillProductId,
                        (bill, detail) => new
                        {
                            detail.ProductId,
                            detail.Quantity,
                            detail.TotalPrice
                        })
                // JOIN 2: Nối với bảng Product để lấy Tên Sản Phẩm
                .Join(listProducts,
                        temp => temp.ProductId,
                        product => product.ProductId,
                        (temp, product) => new
                        {
                            product.ProductName,
                            product.ProductId,
                            temp.Quantity,
                            temp.TotalPrice
                        })
                .GroupBy(x => new { x.ProductId, x.ProductName })
                .Select(g => new
                {
                    MaSP = g.Key.ProductId,
                    TenSP = g.Key.ProductName,
                    TongSoLuong = g.Sum(x => x.Quantity),
                    TongTien = g.Sum(x => x.TotalPrice)
                })
                .ToList();

            List<dynamic> sortedResult = new List<dynamic>();

            switch (cbbSort.SelectedIndex)
            {
                case 0: sortedResult = statisticResult.OrderByDescending(x => x.TongTien).ToList<dynamic>(); break;
                case 1: sortedResult = statisticResult.OrderBy(x => x.TongTien).ToList<dynamic>(); break;
                case 2: sortedResult = statisticResult.OrderByDescending(x => x.TongSoLuong).ToList<dynamic>(); break;
                case 3: sortedResult = statisticResult.OrderBy(x => x.TongSoLuong).ToList<dynamic>(); break;
                default: sortedResult = statisticResult.OrderByDescending(x => x.TongTien).ToList<dynamic>(); break;
            }

            originalData = sortedResult;
            FilterData(textBox1.Text.Trim());
        }

        private void DrawChart(System.Collections.IList data)
        {
            var seriesTien = chartStatistic.Series["SeriesDoanhThu"];
            var seriesSoLuong = chartStatistic.Series["SeriesSoLuong"];

            seriesTien.Points.Clear();
            seriesSoLuong.Points.Clear();

            foreach (dynamic item in data)
            {
                seriesTien.Points.AddXY(item.TenSP, item.TongTien);
                seriesSoLuong.Points.AddXY(item.TenSP, item.TongSoLuong);
            }
            var chartArea = chartStatistic.ChartAreas[0];

            int viewSize = 3;
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

        private void FilterData(string keyword)
        {
            if (originalData == null) return;

            var dataList = originalData.Cast<dynamic>();
            var filteredList = dataList;

            if (!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.ToLower();

                filteredList = dataList.Where(item =>
                    item.TenSP.ToLower().Contains(keyword) ||
                    item.MaSP.ToLower().Contains(keyword) ||
                    item.TongSoLuong.ToString().Contains(keyword) ||
                    item.TongTien.ToString().Contains(keyword)
                ).ToList();
            }
            else
            {
                filteredList = dataList.ToList();
            }

            dataGridView1.DataSource = filteredList.ToList();
            DrawChart(dataList.ToList());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FilterData(textBox1.Text.Trim());
        }
    }
}
