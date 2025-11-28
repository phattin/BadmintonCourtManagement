using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class BillProductGUI : UserControl
    {
        private AccountDTO? currentAccount;
        private BillProductBUS billProductBUS;
        private BillProductDetailBUS detailBUS;

        // Phân trang
        private int page = 0;
        private const int itemsPerPage = 8;
        private int totalPages = 0;
        private List<BillProductDTO> currentBillList = new List<BillProductDTO>();

        public BillProductGUI()
        {
            InitializeComponent();
            billProductBUS = new BillProductBUS();
            detailBUS = new BillProductDetailBUS();
        }

        public BillProductGUI(AccountDTO currentAccount) : this()
        {
            this.currentAccount = currentAccount;
            LoadBills(billProductBUS.GetAllProductBills());
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();
            page = 0;
            if (string.IsNullOrEmpty(keyword))
                LoadBills(billProductBUS.GetAllProductBills());
            else
                LoadBills(billProductBUS.Search(keyword));
        }

        private void btnClearSearch_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            page = 0;
            LoadBills(billProductBUS.GetAllProductBills());
        }

private void LoadBills(List<BillProductDTO>? list = null)
{
    if (list == null)
        list = billProductBUS.GetAllProductBills();

    // Áp dụng tìm kiếm
    string keyword = txtSearch.Text.Trim();
    if (!string.IsNullOrEmpty(keyword))
    {
        list = billProductBUS.Search(keyword);
    }

    // Áp dụng lọc ngày
    DateTime from = dtpFrom.Value.Date;
    DateTime to = dtpTo.Value.Date.AddDays(1).AddSeconds(-1);
    list = list.Where(b => b.DateCreated >= from && b.DateCreated <= to).ToList();

    // Sắp xếp
    switch (cmbSort.SelectedIndex)
    {
        case 0: list = list.OrderByDescending(b => b.DateCreated).ToList(); break;
        case 1: list = list.OrderBy(b => b.DateCreated).ToList(); break;
        case 2: list = list.OrderByDescending(b => b.TotalPrice).ToList(); break;
        case 3: list = list.OrderBy(b => b.TotalPrice).ToList(); break;
    }

    dgvBills.Rows.Clear();
    foreach (var bill in list)
    {
        int rowId = dgvBills.Rows.Add(
            bill.BillProductId,
            bill.DateCreated.ToString("dd/MM/yyyy HH:mm"),
            (string.IsNullOrWhiteSpace(bill.EmployeeId) ? "Không xác định" : bill.EmployeeId),
            bill.TotalPrice.ToString("N0") + " ₫",
            "Xem chi tiết"
        );

        var row = dgvBills.Rows[rowId];
        row.Tag = bill;

        // Cột hành động
        var btn = new DataGridViewButtonCell();
        btn.Value = "Xem chi tiết";
        btn.Style.BackColor = Color.FromArgb(0, 120, 103);
        btn.Style.ForeColor = Color.White;
        btn.Style.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
        dgvBills.Rows[rowId].Cells[4] = btn;
    }
}

private void dgvBills_CellContentClick(object sender, DataGridViewCellEventArgs e)
{
    if (e.ColumnIndex == 4 && e.RowIndex >= 0) // Cột "Hành động"
    {
        var bill = dgvBills.Rows[e.RowIndex].Tag as BillProductDTO;
        if (bill != null)
        {
            var form = new FormBillProductDetail(bill.BillProductId, currentAccount!);
            form.ShowDialog();
            LoadBills(); // Refresh lại nếu có thay đổi
        }
    }
}

private void btnSearch_Click(object sender, EventArgs e) => LoadBills();

        private CustomPanel CreateBillPanel(BillProductDTO bill)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 12,
                BackColor = Color.FromArgb(220, 250, 240),
                Margin = new Padding(12),
                Dock = DockStyle.Fill,
                Cursor = Cursors.Hand
            };

            var tl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 4,
                Padding = new Padding(10)
            };
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tl.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));

            var lblId = new Label
            {
                Text = bill.BillProductId,
                Font = new Font("Segoe UI", 15F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 100, 80),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var lblDate = new Label
            {
                Text = bill.DateCreated.ToString("dd/MM/yyyy HH:mm"),
                Font = new Font("Segoe UI", 11F),
                ForeColor = Color.FromArgb(70, 70, 70),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var lblTotal = new Label
            {
                Text = bill.TotalPrice.ToString("N0") + " ₫",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                ForeColor = Color.FromArgb(0, 120, 103),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Fill
            };

            var btnDetail = new Button
            {
                Text = "Xem chi tiết",
                Height = 40,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                FlatAppearance = { BorderSize = 0 },
                Cursor = Cursors.Hand
            };

            btnDetail.Click += (s, e) =>
            {
                var form = new FormBillProductDetail(bill.BillProductId, currentAccount!);
                form.ShowDialog();
            };

            panel.Click += (s, e) => btnDetail.PerformClick();
            lblId.Click += (s, e) => btnDetail.PerformClick();
            lblDate.Click += (s, e) => btnDetail.PerformClick();
            lblTotal.Click += (s, e) => btnDetail.PerformClick();

            tl.Controls.Add(lblId, 0, 0);
            tl.Controls.Add(lblDate, 0, 1);
            tl.Controls.Add(lblTotal, 0, 2);
            tl.Controls.Add(btnDetail, 0, 3);

            panel.Controls.Add(tl);
            return panel;
        }

        private void UpdatePagination()
        {
            int totalWidth = 400;
            int startX = (paginationPanel.Width - totalWidth) / 2;

            btnExtraPrevious.Location = new Point(startX, 13);
            btnPrevious.Location = new Point(startX + 70, 13);
            btnNext.Location = new Point(startX + 260, 13);
            btnExtraNext.Location = new Point(startX + 330, 13);

            btnExtraPrevious.Enabled = page > 0;
            btnPrevious.Enabled = page > 0;
            btnNext.Enabled = page < totalPages - 1;
            btnExtraNext.Enabled = page < totalPages - 1;

            lblPageInfo.Text = $"Trang {page + 1} / {totalPages}";
            lblPageInfo.Location = new Point(startX + 140, 28);
        }

        // Sự kiện phân trang
        private void btnExtraPrevious_Click(object sender, EventArgs e) { page = 0; LoadBills(currentBillList); }
        private void btnPrevious_Click(object sender, EventArgs e) { if (page > 0) page--; LoadBills(currentBillList); }
        private void btnNext_Click(object sender, EventArgs e) { if (page < totalPages - 1) page++; LoadBills(currentBillList); }
        private void btnExtraNext_Click(object sender, EventArgs e) { page = totalPages - 1; LoadBills(currentBillList); }
    }
}