using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DAO;   // để dùng PriceRuleDAO

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtDetailGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtDTO courtDTO;
        private List<PriceRuleDTO> priceRuleListApplied;

        public BookCourtDetailGUI()
        {
            InitializeComponent();
        }

        public BookCourtDetailGUI(AccountDTO currentAccount, CourtDTO courtDTO)
        {
            this.currentAccount = currentAccount;
            this.courtDTO = courtDTO;
            InitializeComponent();
        }

        // ================== LOAD FORM ==================
        private void BookCourtDetail_Load(object sender, EventArgs e)
        {
            if (courtDTO != null)
                txtCourtID.Text = courtDTO.CourtId;

            // Ngày mặc định: hôm nay
            calBooking.SetDate(DateTime.Today);
            txtDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            // Giờ mặc định: bo tròn về 00 hoặc 30 gần nhất phía sau
            int nowMinute = DateTime.Now.Minute;
            int nowHour = DateTime.Now.Hour;
            if (nowMinute < 15 && nowMinute > 0)
                nowMinute = 15;
            else if (nowMinute < 30)
                nowMinute = 30;
            else if (nowMinute < 45)
                nowMinute = 45;
            else
            {
                nowMinute = 0;
                nowHour += 1;
            }

            var defaultStart = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                nowHour,
                nowMinute,
                0
            );

            timeStartPicker.Value = defaultStart;
            timeEndPicker.Value = defaultStart.AddHours(1);

            // đồng bộ sang bên phải (textbox chỉ hiển thị)
            txtStartTime.Text = timeStartPicker.Value.ToString("HH:mm");
            txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
        }

        // ================== SỰ KIỆN BÊN TRÁI (CHỌN LỊCH & GIỜ) ==================

        private void calBooking_DateSelected(object sender, DateRangeEventArgs e)
        {
            // cập nhật ngày bên phải (read-only)
            txtDate.Text = e.Start.ToString("dd/MM/yyyy");
        }

        private void timeStartPicker_ValueChanged(object sender, EventArgs e)
        {
            // cập nhật giờ bắt đầu bên phải
            txtStartTime.Text = timeStartPicker.Value.ToString("HH:mm");

            // nếu giờ kết thúc <= giờ bắt đầu thì tự đẩy lên +1h
            if (timeEndPicker.Value <= timeStartPicker.Value)
            {
                timeEndPicker.Value = timeStartPicker.Value.AddHours(1);
                txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
            }
        }

        private void timeEndPicker_ValueChanged(object sender, EventArgs e)
        {
            // cập nhật giờ kết thúc bên phải
            txtEndTime.Text = timeEndPicker.Value.ToString("HH:mm");
        }

        // ================== CÁC SỰ KIỆN KHÁC ==================

        private void customPanel3_Paint(object sender, PaintEventArgs e) { }

        private void customPanel2_Paint(object sender, PaintEventArgs e) { }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var bookingGUI = new BookCourtGUI(currentAccount);
            bookingGUI.Dock = DockStyle.Fill;
            this.Controls.Add(bookingGUI);
        }

        // Validate giờ bắt đầu
        private void txtStartTime_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDate.Text))
            {
                MessageBox.Show("Vui lòng chọn ngày");
                txtStartTime.Text = "";
                return;
            }

            if (!string.IsNullOrWhiteSpace(txtStartTime.Text))
            {
                if (TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime))
                {
                    // kiểm tra phút: chỉ cho phép 00, 15, 30, 45
                    if (!(startTime.Minutes == 0 || startTime.Minutes == 15 || startTime.Minutes == 30 || startTime.Minutes == 45))
                    {
                        MessageBox.Show("Chỉ được chọn phút là 00, 15, 30 hoặc 45");
                        txtStartTime.Text = "";
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập giờ hợp lệ (HH:mm, VD: 15:30)");
                    txtStartTime.Text = "";
                }
            }
            UpdatePrice();
        }

        // Validate giờ kết thúc
        private void txtEndTime_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStartTime.Text))
            {
                MessageBox.Show("Vui lòng chọn giờ bắt đầu");
                txtEndTime.Text = "";
                return;
            }

            if (TimeSpan.TryParse(txtStartTime.Text, out TimeSpan startTime) &&
                TimeSpan.TryParse(txtEndTime.Text, out TimeSpan endTime))
            {
                // tối thiểu 1 tiếng
                if ((endTime - startTime).TotalMinutes < 60)
                {
                    MessageBox.Show("Thời gian đặt tối thiểu là 1 tiếng");
                    txtEndTime.Text = "";
                    return;
                }

                // phút phải là 00, 15, 30 hoặc 45
                if (!((startTime.Minutes == 0 || startTime.Minutes == 15 || startTime.Minutes == 30 || startTime.Minutes == 45) &&
                      (endTime.Minutes == 0 || endTime.Minutes == 15 || endTime.Minutes == 30 || endTime.Minutes == 45)))
                {
                    MessageBox.Show("Chỉ được đặt ở phút 00, 15, 30 hoặc 45");
                    txtEndTime.Text = "";
                    return;
                }
                UpdatePrice();

            }
            else
            {
                MessageBox.Show("Vui lòng nhập giờ hợp lệ (HH:mm, VD: 15:30)");
                txtTotalPrice.Text = "";
            }
        }

        private void UpdatePrice()
        {
            priceRuleListApplied = new List<PriceRuleDTO>();

            // 1️⃣ Lấy bookingDate
            if (!DateOnly.TryParseExact(txtDate.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateOnly bookingDate))
            {
                MessageBox.Show("Ngày đặt không hợp lệ");
                return;
            }

            // 2️⃣ Lấy giờ bắt đầu và kết thúc
            if (!TimeOnly.TryParse(txtStartTime.Text, out TimeOnly startTime) ||
                !TimeOnly.TryParse(txtEndTime.Text, out TimeOnly endTime))
            {
                MessageBox.Show("Giờ bắt đầu hoặc kết thúc không hợp lệ");
                return;
            }

            // 3️⃣ Tạo DAO
            var priceRuleDao = new PriceRuleDAO();

            // 4️⃣ Lặp qua từng khung 15 phút
            TimeOnly currentStart = startTime;
            while (currentStart < endTime)
            {
                TimeOnly currentEnd = currentStart.AddMinutes(15);

                // tránh vượt quá endTime
                if (currentEnd > endTime)
                    currentEnd = endTime;

                // 5️⃣ Lấy PriceRule cho khung giờ hiện tại
                PriceRuleDTO rule = priceRuleDao.GetPriceRuleByTime(currentStart, currentEnd, bookingDate);
                if (rule != null)
                    priceRuleListApplied.Add(rule);

                // 6️⃣ Bước sang khung giờ tiếp theo
                currentStart = currentEnd;
            }

            // 7️⃣ Tính tổng tiền
            double totalPrice = 0;
            foreach (var rule in priceRuleListApplied)
            {
                totalPrice += rule.Price * 0.25; // 0.25 giờ = 15 phút
            }

            txtTotalPrice.Text = totalPrice.ToString("0");
        }



        private void calBooking_DateChanged(object sender, DateRangeEventArgs e) { }

        private void lblCalStart_Click(object sender, EventArgs e) { }

        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            UpdatePrice();  
        }
    }
}
