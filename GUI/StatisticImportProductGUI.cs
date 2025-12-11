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

namespace GUI
{
    public partial class StatisticImportProductGUI : UserControl
    {
        private System.Collections.IList originalData;
        public StatisticImportProductGUI()
        {
            InitializeComponent();
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            LoadStatisticImportData();
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            LoadStatisticImportData();
        }

        private void LoadStatisticImportData()
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }

            BillImportBUS importBillBUS = new BillImportBUS();
            var listImportBills = importBillBUS.GetAllImportBills();
            BillImportDetailBUS importDetailBUS = new BillImportDetailBUS();
            var listImportDetails = importDetailBUS.GetAllDetailImportBills();
            ProductBUS productBUS = new ProductBUS();
            var listProducts = productBUS.GetAllProducts();

            DateTime fromDate = dateTimePicker1.Value.Date;
            DateTime toDate = dateTimePicker2.Value.Date;

            var query = listImportBills
                .Where(b =>
                    (b.Status == ImportBillDTO.Option.paid) &&
                    b.DateCreated.Date >= fromDate &&
                    b.DateCreated.Date <= toDate
                )
                // JOIN 1: Nối với chi tiết nhập
                .Join(listImportDetails,
                        bill => bill.ImportBillId,
                        detail => detail.ImportBillId,
                        (bill, detail) => new
                        {
                            detail.ProductId,
                            detail.Quantity,
                            detail.TotalPrice
                        })
                // JOIN 2: Nối với Product để lấy tên
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
                    TongChiPhi = g.Sum(x => x.TotalPrice)
                })
                .ToList();

            List<dynamic> sortedResult = new List<dynamic>();
            switch (cbbSort.SelectedIndex)
            {
                case 0: sortedResult = query.OrderByDescending(x => x.TongChiPhi).ToList<dynamic>(); break;
                case 1: sortedResult = query.OrderBy(x => x.TongChiPhi).ToList<dynamic>(); break;
                case 2: sortedResult = query.OrderByDescending(x => x.TongSoLuong).ToList<dynamic>(); break;
                case 3: sortedResult = query.OrderBy(x => x.TongSoLuong).ToList<dynamic>(); break;
                default: sortedResult = query.OrderByDescending(x => x.TongChiPhi).ToList<dynamic>(); break;
            }

            originalData = sortedResult;
            FilterData(textBox1.Text.Trim());
        }

        private void DrawChart(System.Collections.IList data)
        {
            var seriesTien = chartStatistic.Series["SeriesChiPhi"];
            var seriesSoLuong = chartStatistic.Series["SeriesSoLuong"];

            seriesTien.Points.Clear();
            seriesSoLuong.Points.Clear();

            foreach (dynamic item in data)
            {
                seriesTien.Points.AddXY(item.TenSP, item.TongChiPhi);
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
                    item.TongChiPhi.ToString().Contains(keyword)
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
