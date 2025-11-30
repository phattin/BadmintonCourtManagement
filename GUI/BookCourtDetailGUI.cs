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

        private void BookCourtDetail_Load(object sender, EventArgs e)
        {
            txtCourtID.Text = courtDTO.CourtId;

            int nowMinute = DateTime.Now.Minute;
            int nowHour = DateTime.Now.Hour;
            if (nowMinute < 30)
                nowMinute = 30;
            else
            {
                nowMinute = 0;
                nowHour += 1;
            }
            btnStartTime.SelectedTime = new DateTime(2025, 10, 4, nowHour, nowMinute, 32, 333);

            btnEndTime.SelectedTime = new DateTime(2025, 10, 4, nowHour, nowMinute, 32, 333);
        }


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

                    // Kiểm tra khoảng giờ hợp lệ
                    if (startTime < minTime || startTime >= maxTime)
                    {
                        MessageBox.Show("Giờ bắt đầu phải nằm trong khoảng 5h00 - 23h00");
                        txtStartTime.Text = "";
                        return;
                    }

                    // Kiểm tra phút chỉ được là 00 hoặc 30
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

        }zzzs

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

                // Thời gian tối thiểu 1 giờ
                if ((endTime - startTime).TotalMinutes < 60)
                {
                    MessageBox.Show("Thời gian đặt tối thiểu là 1 tiếng");
                    txtEndTime.Text = "";
                    return;
                }

                // Kiểm tra phút chỉ được là 00 hoặc 30
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
                    TimeSpan next = current.Add(new TimeSpan(0, 30, 0)); // cộng 30 phút
                    if (next > endTime) next = endTime;

                    // Nếu block này nằm trong khung 5h-16h
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

        private void btnStartTime_Load(object sender, EventArgs e)
        {

        }
        
        private void btnStartTime_ValueChanged(object sender, EventArgs e)
        {
            txtStartTime.Text = btnStartTime.SelectedTime.ToString("HH:mm");
        }

        private void btnEndTime_ValueChanged(object sender, EventArgs e)
        {
            txtEndTime.Text = btnEndTime.SelectedTime.ToString("HH:mm");
        }
    }
}
