using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.Runtime.InteropServices;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtBUS courtBUS;
        private BookingBUS bookingBUS;

        public BookCourtGUI(AccountDTO account)
        {
            // AccountDTO accountCurrent = account;
            currentAccount = account;
            InitializeComponent();
            courtBUS = new CourtBUS();
            bookingBUS = new BookingBUS();
            List<CourtDTO> courts = courtBUS.GetAllCourts();

            LoadCourts(courts);
        }

        private void PCourtList_Resize(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // xử lý khi đặt sân
        }

        private void pCourt_Paint(object sender, PaintEventArgs e)
        {
            // nếu cần custom vẽ thêm
        }

        private void pFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCourt2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCourt3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void draft_panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTimeStart_Load(object sender, EventArgs e)
        {

        }

        private void btnTimeStart_ValueChanged(object sender, EventArgs e)
        {
            lbltimeStart.Text = btnTimeStart.SelectedTime.ToString("HH:mm");
        }

        private void btnTimeFinish_Load(object sender, EventArgs e)
        {

        }

        private void btnTimeFinish_ValueChanged(object sender, EventArgs e)
        {
            lbltimeFinish.Text = btnTimeFinish.SelectedTime.ToString("HH:mm");
        }


        //private void pCourtList_Resize(object sender, EventArgs e)
        //{
        //    int soSanMoiDong = 4;
        //    int panelWidth = pCourtList.ClientSize.Width / soSanMoiDong - 15;
        //    int panelHeight = pCourtList.ClientSize.Height / 2 - 20;

        //    foreach (Control ctrl in pCourtList.Controls)
        //    {
        //        if (ctrl is CustomPanel panel)
        //        {
        //            panel.Width = panelWidth;
        //            panel.Height = panelHeight;
        //        }
        //    }
        //}


        private void LoadCourts(List<CourtDTO> danhSachSan)
        {
            pCourtList.Controls.Clear();
            pCourtList.ColumnCount = 4;
            pCourtList.RowCount = 2;

            for (int i = 0; i < 4; i++)
                pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int index = 0;
            foreach (CourtDTO courtDTO in danhSachSan)
            {
                var panel = CreateCourtPanel(courtDTO);
                int row = index / 4;
                int col = index % 4;
                pCourtList.Controls.Add(panel, col, row);
                index++;
            }
        }

        private void pCourtList_Paint(object sender, PaintEventArgs e)
        {

        }
        private CustomPanel CreateCourtPanel(CourtDTO courtDTO)
        {

            List<BookingDTO> successfulBookingList = bookingBUS.GetSuccessfulBookingsByCourtID(courtDTO.CourtId);
            BookingDTO nextBooking = new BookingDTO();
            string nextBookingStartTime = "";
            string nextBookingEndTime = "";
            if (successfulBookingList.Count > 0)
            {
                nextBooking = successfulBookingList.OrderBy(b => b.StartTime).First();
                nextBookingStartTime = nextBooking.StartTime.ToString("HH:mm");
                nextBookingEndTime = nextBooking.EndTime.ToString("HH:mm");
            }

            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 250, 214),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tlCourt = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3
            };

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));

            // Label tên sân
            var lblName = new Label
            {
                Text = courtDTO.CourtName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            string bookingTimeText = "";
            if (nextBookingStartTime != "" && nextBookingEndTime != "")
                bookingTimeText = "Tình trạng: Đã đặt\nBooking tiếp theo: " + nextBookingStartTime + "-" + nextBookingEndTime;
            else
                bookingTimeText = "Tình trạng: Trống\nBooking tiếp theo: Không có";
            // Label thông tin
            var lblInfo = new Label
            {
                Text = bookingTimeText,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 9F),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Nút đặt sân
            var btnBooking = new Button
            {
                Text = "Đặt sân",
                Width = 200,
                Height = 40,
                Anchor = AnchorStyles.Bottom,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0, 0, 0, 10)
            };

            btnBooking.Click += (s, e) =>
            {
                this.Controls.Clear();
                var bookingCourtDetailGUI = new BookCourtDetailGUI(currentAccount, courtDTO);
                bookingCourtDetailGUI.Dock = DockStyle.Fill;
                this.Controls.Add(bookingCourtDetailGUI);
            };

            tlCourt.Controls.Add(lblName, 0, 0);
            tlCourt.Controls.Add(lblInfo, 0, 1);
            tlCourt.Controls.Add(btnBooking, 0, 2);

            panel.Controls.Add(tlCourt);

            return panel;
        }

        private void customPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}