using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class hoadonGUI : UserControl
    {
        private AccountDTO? currentAccount;

        // Danh sách dữ liệu gốc (chỉ load 1 lần)
        private List<hoadonDTO> masterList = new();
        private List<hoadonDTO> filteredList = new();

        // Phân trang
        private int currentPage = 0;
        private const int ItemsPerPage = 10;
        private int totalPages = 0;

        public hoadonGUI()
        {
            InitializeComponent();
            InitializeCustomComponents();
        }

        public hoadonGUI(AccountDTO currentAccount) : this()
        {
            this.currentAccount = currentAccount;
            LoadAllBills();
        }

        private void InitializeCustomComponents()
        {
            // Cấu hình DataGridView
            dgvBills.AllowUserToAddRows = false;
            dgvBills.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBills.MultiSelect = false;
            dgvBills.ReadOnly = true;
            dgvBills.RowHeadersVisible = false;
            dgvBills.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // ComboBox sắp xếp
            cmbSort.SelectedIndex = 0;

            // DateTimePicker mặc định 30 ngày gần nhất
            dtpFrom.Value = DateTime.Today.AddDays(-30);
            dtpTo.Value = DateTime.Today.AddDays(1);


        }

        private void LoadAllBills()
        {
            masterList = hoadonBUS.GetAllNewest(); // Chỉ gọi 1 lần
            ApplyFiltersAndRefresh();
        }

        private void ApplyFiltersAndRefresh()
        {
            filteredList = new List<hoadonDTO>(masterList);

            string keyword = txtSearch.Text.Trim().ToLower();

            // 1. Tìm kiếm
            if (!string.IsNullOrEmpty(keyword))
            {
                filteredList = filteredList.Where(b =>
                    b.BillBookingId.ToLower().Contains(keyword) ||
                    (b.CustomerName?.ToLower().Contains(keyword) ?? false) ||
                    (b.Phone?.Contains(keyword) ?? false) ||
                    (b.CourtName?.ToLower().Contains(keyword) ?? false)
                ).ToList();
            }

            // 2. Lọc theo ngày (ngày chơi)
            DateTime from = dtpFrom.Value.Date;
            DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);
            filteredList = filteredList
                .Where(b => b.StartTime >= from && b.StartTime <= to)
                .ToList();

            // 3. Sắp xếp theo ComboBox
            filteredList = cmbSort.SelectedIndex switch
            {
                0 => filteredList.OrderByDescending(b => b.StartTime).ToList(),
                1 => filteredList.OrderBy(b => b.StartTime).ToList(),
                2 => filteredList.OrderByDescending(b => b.TotalPrice).ToList(),
                3 => filteredList.OrderBy(b => b.TotalPrice).ToList(),
                _ => filteredList.OrderByDescending(b => b.StartTime).ToList()
            };

            // 4. Phân trang
            currentPage = 0;
            totalPages = (int)Math.Ceiling(filteredList.Count / (double)ItemsPerPage);
            DisplayCurrentPage();
        }

        private void DisplayCurrentPage()
        {
            dgvBills.Rows.Clear();

            var pageItems = filteredList
                .Skip(currentPage * ItemsPerPage)
                .Take(ItemsPerPage)
                .ToList();

            foreach (var bill in pageItems)
            {
                string statusText = bill.Status == hoadonDTO.BookingStatus.played ? "Đã chơi" : "Đã đặt";
                string statusColor = bill.Status == hoadonDTO.BookingStatus.played ? "#E8F5E5E" : "#4CAF50";

                string prePaidText = bill.PrePayment > 0
                    ? bill.PrePayment.ToString("N0") + "đ"
                    : "Chưa cọc";

                string remaining = bill.RemainingAmount > 0
                    ? $"(Còn nợ: {bill.RemainingAmount:N0}đ)"
                    : "(Đã thanh toán đủ)";

                int rowIndex = dgvBills.Rows.Add(
                    bill.BillBookingId,
                    bill.StartTime.ToString("dd/MM/yyyy HH:mm"),
                    bill.CourtName ?? "Chưa xác định",
                    bill.CustomerName ?? "Khách lẻ",
                    bill.TotalPrice.ToString("N0") + "đ",
                    prePaidText,
                    statusText,
                    "Xem chi tiết"
                );

                var row = dgvBills.Rows[rowIndex];
                row.Tag = bill;

                // // Tô màu trạng thái
                // if (bill.Status == hoadonDTO.BookingStatus.played)
                // {
                //     row.DefaultCellStyle.BackColor = Color.FromArgb(240, 255, 240); // Xanh nhạt
                //     row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(200, 255, 200);
                // }
                // else if (bill.RemainingAmount > 0)
                // {
                //     row.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 220); // Vàng nhạt
                //     row.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 255, 180);
                // }

                // Nút "Xem chi tiết"
                var btnCell = row.Cells[colAction.Index] as DataGridViewButtonCell;
                if (btnCell != null)
                {
                    btnCell.Value = "Xem chi tiết";
                    btnCell.Style.BackColor = Color.FromArgb(0, 120, 103);
                    btnCell.Style.ForeColor = Color.White;
                    btnCell.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                    btnCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    btnCell.Style.Padding = new Padding(0, 5, 0, 5);
                }
            }
        }



        // ==================== SỰ KIỆN ====================

        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFiltersAndRefresh();
        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            ApplyFiltersAndRefresh();
        }

        private void btnSearch_Click(object sender, EventArgs e) => ApplyFiltersAndRefresh();

        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e) => ApplyFiltersAndRefresh();

        private void dtpFrom_ValueChanged(object sender, EventArgs e) => ApplyFiltersAndRefresh();
        private void dtpTo_ValueChanged(object sender, EventArgs e) => ApplyFiltersAndRefresh();

        // Phân trang
        private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex != colAction.Index) return;

            if (dgvBills.Rows[e.RowIndex].Tag is hoadonDTO bill)
            {
                var detailForm = new FormhoadonDetail(bill.BillBookingId, currentAccount!);
                if (detailForm.ShowDialog() == DialogResult.OK)
                {
                    LoadAllBills(); // Refresh nếu có thay đổi (ví dụ: cập nhật trạng thái, thanh toán)
                }
            }
        }

        // Nút làm mới (nếu bạn có)
        private void btnRefresh_Click(object sender, EventArgs e) => LoadAllBills();
    }
}