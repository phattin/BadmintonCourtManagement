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
        private List<ImportBillDTO> listImportBills;
        private List<BillImportDetailDTO> listImportDetails;
        private List<ProductDTO> listProducts;
        public StatisticImportProductGUI(List<ImportBillDTO> listImportBills, List<BillImportDetailDTO> listImportDetails, List<ProductDTO> listProducts)
        {
            InitializeComponent();
            this.listImportBills = listImportBills;
            this.listImportDetails = listImportDetails;
            this.listProducts = listProducts;
            dateTimePicker1.Value = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            dateTimePicker2.Value = DateTime.Now;
            LoadStatisticImportData(listImportBills, listImportDetails, listProducts);
        }

        private void buttonTK_Click(object sender, EventArgs e)
        {
            LoadStatisticImportData(listImportBills, listImportDetails, listProducts);
        }

        private void LoadStatisticImportData(List<ImportBillDTO> listImportBills, List<BillImportDetailDTO> listImportDetails, List<ProductDTO> listProducts)
        {
            if (dateTimePicker1.Value.Date > dateTimePicker2.Value.Date)
            {
                MessageBox.Show("Ngày bắt đầu không được lớn hơn ngày kết thúc!");
                return;
            }

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
                });

            var sortedResult = cbbSort.SelectedIndex switch
            {
                0 => query.OrderByDescending(x => x.TongChiPhi).ToList(),
                1 => query.OrderBy(x => x.TongChiPhi).ToList(),
                2 => query.OrderByDescending(x => x.TongSoLuong).ToList(),
                3 => query.OrderBy(x => x.TongSoLuong).ToList(),
                _ => query.OrderByDescending(x => x.TongChiPhi).ToList()
            };

            dataGridView1.DataSource = sortedResult;
            DrawChart(sortedResult);
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
    }
}
