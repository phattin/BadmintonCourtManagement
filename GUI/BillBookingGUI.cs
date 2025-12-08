using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class BillBookingGUI : UserControl
    {
        private AccountDTO? currentAccount;
        private BillBookingBUS billBookingBUS = new BillBookingBUS();

        // Phân trang
        private int page = 0;
        private const int itemsPerPage = 8;
        private int totalPages = 0;
        private List<BillBookingDTO> currentBillList = new List<BillBookingDTO>();

        public BillBookingGUI()
        {
            InitializeComponent();
        }

        public BillBookingGUI(AccountDTO currentAccount) : this()
        {
            this.currentAccount = currentAccount;
            LoadBills(BillBookingBUS.GetAll());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            page = 0;
            LoadBills();
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            page = 0;
            LoadBills(BillBookingBUS.GetAll());
        
        }

        private void LoadBills(List<BillBookingDTO>? list = null)
        {
            if (list == null)
                list = BillBookingBUS.GetAll();

            currentBillList = list;

            // Áp dụng tìm kiếm
            string keyword = txtSearch.Text.Trim();
            if (!string.IsNullOrEmpty(keyword))
            {
                list = BillBookingBUS.Search(keyword);
            }

            // Áp dụng lọc ngày (theo ngày đặt sân)
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);
            list = list.Where(b => b.StartTime >= from && b.StartTime <= to).ToList();

            // Sắp xếp
            switch (cmbSort.SelectedIndex)
            {
                case 0: list = list.OrderByDescending(b => b.StartTime).ToList(); break;  // Mới nhất
                case 1: list = list.OrderBy(b => b.StartTime).ToList(); break;             // Cũ nhất
                case 2: list = list.OrderByDescending(b => b.TotalPrice).ToList(); break; // Tổng tiền giảm
                case 3: list = list.OrderBy(b => b.TotalPrice).ToList(); break;            // Tổng tiền tăng
            }

            // Phân trang
            totalPages = (int)Math.Ceiling((double)list.Count / itemsPerPage);
            var pageItems = list.Skip(page * itemsPerPage).Take(itemsPerPage).ToList();

            dgvBills.Rows.Clear();
            foreach (var bill in pageItems)
            {
                string statusText = bill.BookingStatus == "played" ? "Đã chơi" : "Đã đặt";
                string prePaid = bill.PrePayment > 0 ? bill.PrePayment.ToString("N0") + "đ" : "Chưa cọc";

                int rowId = dgvBills.Rows.Add(
                    bill.BillBookingId,
                    bill.StartTime.ToString("dd/MM/yyyy HH:mm"),
                    bill.CourtName,
                    bill.CustomerName,
                    bill.TotalPrice.ToString("N0") + "đ",
                    prePaid,
                    statusText,
                    "Xem chi tiết"
                );

                var row = dgvBills.Rows[rowId];
                row.Tag = bill;

                // Nút "Xem chi tiết"
                var btnCell = new DataGridViewButtonCell
                {
                    Value = "Xem chi tiết",
                    Style = new DataGridViewCellStyle
                    {
                        BackColor = Color.FromArgb(0, 120, 103),
                        ForeColor = Color.White,
                        Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                        Alignment = DataGridViewContentAlignment.MiddleCenter
                    }
                };
                dgvBills.Rows[rowId].Cells[7] = btnCell;
            }


        }

        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7 && e.RowIndex >= 0) // Cột "Xem chi tiết"
            {
                var bill = dgvBills.Rows[e.RowIndex].Tag as BillBookingDTO;
                if (bill != null)
                {
                    var form = new FormBillBookingDetail(bill.BillBookingId, currentAccount!);
                    form.ShowDialog();
                    LoadBills(); // Refresh sau khi xem/sửa
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            page = 0;
            LoadBills();
        }

     
        // === PHÂN TRANG ===
        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadBills(currentBillList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) page--; LoadBills(currentBillList); }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) page++; LoadBills(currentBillList); }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = Math.Max(0, totalPages - 1); LoadBills(currentBillList); }

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            List<BillBookingDTO> list = cmbSort.SelectedIndex switch
            {
                0 => string.IsNullOrEmpty(keyword) ? BillBookingBUS.GetAllNewest() : BillBookingBUS.SearchNewest(keyword),
                1 => string.IsNullOrEmpty(keyword) ? BillBookingBUS.GetAllOldest() : BillBookingBUS.SearchOldest(keyword),
                2 => string.IsNullOrEmpty(keyword) ? BillBookingBUS.GetAllPriceDesc() : BillBookingBUS.SearchPriceDesc(keyword),
                3 => string.IsNullOrEmpty(keyword) ? BillBookingBUS.GetAllPriceAsc() : BillBookingBUS.SearchPriceAsc(keyword),
                _ => BillBookingBUS.GetAllNewest()
            };
            LoadBills(list);
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e) => LoadBills(currentBillList);
        private void dtpTo_ValueChanged(object sender, EventArgs e) => LoadBills(currentBillList);
    }
}