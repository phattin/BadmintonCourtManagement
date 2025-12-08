using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormBillBookingDetail : Form
    {
        private readonly string _billId;
        private readonly BillBookingBUS _billBus = new BillBookingBUS();
        private readonly AccountDTO? _account;

        public FormBillBookingDetail(string billBookingId, AccountDTO? account = null)
        {
            _billId = billBookingId;
            _account = account;
            InitializeComponent();
        }

        private void FormBillBookingDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();

            // Hiệu ứng hover cho nút Đóng
            btnClose.MouseEnter += (s, args) => btnClose.BackColor = Color.FromArgb(200, 70, 70);
            btnClose.MouseLeave += (s, args) => btnClose.BackColor = Color.FromArgb(180, 60, 60);
        }

private void LoadBillDetail()
{
    try
    {
        var bill = _billBus.GetBillBookingById(_billId);
        if (bill == null)
        {
            MessageBox.Show("Không tìm thấy hóa đơn đặt sân này!", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
            // this.Close();
            return;
        }

        // Thông tin hóa đơn
        lblBillId.Text       = $"Mã hóa đơn:\n{bill.BillBookingId}";
        lblEmployee.Text     = $"Nhân viên:\n{(string.IsNullOrWhiteSpace(bill.EmployeeName) ? "Không xác định" : bill.EmployeeName)}";
        lblCustomer.Text     = $"Khách hàng:\n{bill.CustomerName}\nSĐT: {bill.Phone}";
        lblCourt.Text        = $"Sân:\n{bill.CourtName}";
        lblTime.Text         = $"Thời gian chơi:\n{bill.StartTime:dd/MM/yyyy HH:mm} → {bill.EndTime:HH:mm}";
        lblStatus.Text       = $"Trạng thái:\n{(bill.BookingStatus == "played" ? "Đã chơi" : "Đã đặt sân")}";
        lblTotalPrice.Text   = $"TỔNG TIỀN:\n{bill.TotalPrice:N0} ₫";
        lblPrePaid.Text      = $"Đã cọc:\n{bill.PrePayment:N0} ₫";

        // SỬA LẠI DÒNG NÀY – ĐÂY LÀ LỖI CHÍNH!
        double remaining = bill.TotalPrice - bill.PrePayment;
        lblRemaining.Text    = $"Còn lại:\n{remaining:N0} ₫";

        // Bonus: đổi màu nếu còn nợ
        lblRemaining.ForeColor = remaining > 0 ? Color.Red : Color.Green;
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi tải dữ liệu chi tiết hóa đơn:\n" + ex.Message + "\n\n" + ex.StackTrace, 
            "Lỗi nghiêm trọng", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}