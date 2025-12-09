using System;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormBillBookingDetail : Form
    {
        private readonly string _billId;
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

            // Hiệu ứng hover nút đóng
            btnClose.MouseEnter += (s, args) => btnClose.BackColor = Color.FromArgb(200, 70, 70);
            btnClose.MouseLeave += (s, args) => btnClose.BackColor = Color.FromArgb(180, 60, 60);
        }

        private void LoadBillDetail()
        {
            try
            {
                // SỬA CHỖ NÀY: Dùng GetById thay vì GetBillBookingById
                var bill = BillBookingBUS.GetById(_billId);

                if (bill == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn đặt sân này!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.DialogResult = DialogResult.Cancel;
                    this.Close();
                    return;
                }

                // Hiển thị thông tin
                lblBillId.Text       = $"Mã hóa đơn:\n{bill.BillBookingId}";
                lblEmployee.Text     = $"Nhân viên:\n{bill.EmployeeName ?? "Không xác định"}";
                lblCustomer.Text     = $"Khách hàng:\n{bill.CustomerName ?? "Khách lẻ"}\nSĐT: {bill.Phone ?? "Chưa có"}";
                lblCourt.Text        = $"Sân:\n{bill.CourtName ?? "Chưa xác định"}";
                lblTime.Text         = $"Thời gian chơi:\n{bill.StartTime:dd/MM/yyyy HH:mm} → {bill.EndTime:HH:mm}";
                
                // Dùng enum đúng cách
                string statusText = bill.Status == BillBookingDTO.BookingStatus.played ? "Đã chơi" : "Đã đặt sân";
                lblStatus.Text       = $"Trạng thái:\n{statusText}";

                lblTotalPrice.Text   = $"TỔNG TIỀN:\n{bill.TotalPrice:N0} ₫";
                lblPrePaid.Text      = $"Đã cọc:\n{bill.PrePayment:N0} ₫";

                // Dùng thuộc tính tính sẵn – đẹp hơn!
                double remaining = bill.RemainingAmount;
                lblRemaining.Text    = $"Còn lại:\n{remaining:N0} ₫";

                // Đổi màu theo tình trạng thanh toán
                lblRemaining.ForeColor = remaining > 0 ? Color.Red : Color.FromArgb(0, 150, 0);
                lblRemaining.Font = new Font(lblRemaining.Font, remaining > 0 ? FontStyle.Bold : FontStyle.Regular);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu chi tiết hóa đơn:\n" + ex.Message,
                    "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}