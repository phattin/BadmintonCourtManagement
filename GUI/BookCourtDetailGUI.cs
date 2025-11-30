using System;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.BUS;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtDetailGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtDTO courtDTO;

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
            if (nowMinute < 30)
                nowMinute = 30;
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

        private void customPanel3_Paint(object sender, PaintEventArgs e)
        {
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var bookingGUI = new BookCourtGUI(currentAccount);
            bookingGUI.Dock = DockStyle.Fill;
            this.Controls.Add(bookingGUI);
        }

        // Validate giờ bắt đầu (textbox chỉ nhận text từ timeStartPicker)
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
                    TimeSpan minTime = new TimeSpan(5, 0, 0);   // 5h00
                    TimeSpan maxTime = new TimeSpan(23, 0, 0);  // 23h00

                    if (startTime < minTime || startTime >= maxTime)
                    {
                        MessageBox.Show("Giờ bắt đầu phải nằm trong khoảng 5h00 - 23h00");
                        txtStartTime.Text = "";
                        return;
                    }

                    if (!(startTime.Minutes == 0 || startTime.Minutes == 30))
                    {
                        MessageBox.Show("Chỉ được chọn phút là 00 hoặc 30");
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
        }

        // Validate giờ kết thúc + tính tiền
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
                TimeSpan minTime = new TimeSpan(5, 0, 0);
                TimeSpan maxTime = new TimeSpan(23, 0, 0);

                if (endTime > maxTime)
                {
                    MessageBox.Show("Thời gian chỉ được đặt trong khoảng 5h00 - 23h00");
                    txtEndTime.Text = "";
                    return;
                }

                if (endTime <= startTime)
                {
                    MessageBox.Show("Giờ kết thúc phải sau giờ bắt đầu");
                    txtEndTime.Text = "";
                    return;
                }

                if ((endTime - startTime).TotalMinutes < 60)
                {
                    MessageBox.Show("Thời gian đặt tối thiểu là 1 tiếng");
                    txtEndTime.Text = "";
                    return;
                }

                if (!((startTime.Minutes == 0 || startTime.Minutes == 30) &&
                      (endTime.Minutes == 0 || endTime.Minutes == 30)))
                {
                    MessageBox.Show("Chỉ được đặt ở phút 00 hoặc 30");
                    txtEndTime.Text = "";
                    return;
                }

                // Tính tiền theo block 30 phút
                decimal totalPrice = 0;
                TimeSpan current = startTime;

                while (current < endTime)
                {
                    TimeSpan next = current.Add(new TimeSpan(0, 30, 0));
                    if (next > endTime) next = endTime;

                    if (current >= new TimeSpan(5, 0, 0) && current < new TimeSpan(16, 0, 0))
                    {
                        totalPrice += 30000; // 30k mỗi 30 phút
                    }
                    else if (current >= new TimeSpan(16, 0, 0) && current < new TimeSpan(23, 0, 0))
                    {
                        totalPrice += 40000; // 40k mỗi 30 phút
                    }

                    current = next;
                }

                txtTotalPrice.Text = totalPrice.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập giờ hợp lệ (HH:mm, VD: 15:30)");
                txtTotalPrice.Text = "";
            }
        }
    }
}
