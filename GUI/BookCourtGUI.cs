using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.Globalization;
using System.Runtime.InteropServices;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtBUS courtBUS;
        private BookingBUS bookingBUS;

        // ===== Thêm các biến phân trang =====
        private List<CourtDTO> currentList = new List<CourtDTO>();
        private int currentPage;
        private int itemsPerPage;
        private int totalPages;
        // ===================================

        public BookCourtGUI(AccountDTO account)
        {
            currentAccount = account;
            InitializeComponent();
            courtBUS = new CourtBUS();
            bookingBUS = new BookingBUS();

            // Khởi tạo phân trang
            currentPage = 1;
            itemsPerPage = 8;
            totalPages = 1;

            // Giờ mặc định: bo tròn về 00, 15, 30, 45 gần nhất phía sau
            int nowMinute = DateTime.Now.Minute;
            int nowHour = DateTime.Now.Hour;

            if (nowMinute < 15)
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

            lbltimeStart.Text = defaultStart.ToString("HH:mm");

            lblDate.Text = DateTime.Now.ToString("dd/MM/yyyy");

            lbltimeFinish.Text = defaultStart.AddHours(2).ToString("HH:mm");

            ReloadCourtList();
        }

        private void ReloadCourtList()
        {
            currentList = courtBUS.GetActiveCourts();

            //// DEBUG: Kiểm tra xem có bao nhiêu sân active
            //MessageBox.Show($"Số sân hoạt động: {currentList.Count}");

            LoadCourts(currentList, 1);
        }


        private void PCourtList_Resize(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // xử lý khi đặt sân
        }

        private void pCourt_Paint(object sender, PaintEventArgs e) { }
        private void pFilter_Paint(object sender, PaintEventArgs e) { }
        private void pCourt2_Paint(object sender, PaintEventArgs e) { }
        private void pCourt3_Paint(object sender, PaintEventArgs e) { }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void TxtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // TÌM KIẾM CHỈ TRONG SÂN HOẠT ĐỘNG
                string keyword = txtSearch.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    currentList = courtBUS.GetActiveCourts();
                }
                else
                {
                    // Tìm kiếm và lọc chỉ lấy sân hoạt động
                    var searchResults = courtBUS.Search(keyword);
                    currentList = searchResults.Where(c => c.Status == CourtDTO.Option.active).ToList();
                }
                LoadCourts(currentList, 1);
                e.Handled = true;
                e.SuppressKeyPress = true; // không phát ra tiếng "bing"
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
            ReloadCourtList();
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e) { }
        private void draft_panel_Paint(object sender, PaintEventArgs e) { }
        private void btnTimeStart_Load(object sender, EventArgs e) {
            btnTimeStart.SelectedTime = DateTime.ParseExact(
                lbltimeStart.Text,
                "HH:mm",
                CultureInfo.InvariantCulture
            );
        }

        private void btnTimeStart_ValueChanged(object sender, EventArgs e)
        {
            lbltimeStart.Text = btnTimeStart.SelectedTime.ToString("HH:mm");
            ReloadCourtList();
        }

        private void btnTimeFinish_Load(object sender, EventArgs e) {
            btnTimeFinish.SelectedTime = DateTime.ParseExact(
                lbltimeFinish.Text,
                "HH:mm",
                CultureInfo.InvariantCulture
            );
        }

        private void btnTimeFinish_ValueChanged(object sender, EventArgs e)
        {
            lbltimeFinish.Text = btnTimeFinish.SelectedTime.ToString("HH:mm");
            ReloadCourtList();
        }

        // ================== PHÂN TRANG ==================
        private void LoadCourts(List<CourtDTO> danhSachSan, int pageNumber)
        {
            totalPages = (int)Math.Ceiling((double)danhSachSan.Count / itemsPerPage);
            if (totalPages == 0) totalPages = 1;

            // Ẩn/hiện nút phân trang giống CourtManagementGUI
            if (totalPages == 1)
            {
                previousButton.Visible = false;
                nextButton.Visible = false;
                extraPreviousButton.Visible = false;
                extraNextButton.Visible = false;
            }
            else
            {
                previousButton.Visible = true;
                nextButton.Visible = true;
                extraPreviousButton.Visible = true;
                extraNextButton.Visible = true;
            }

            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;
            currentPage = pageNumber;

            int startIndex = (pageNumber - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, danhSachSan.Count);
            var pageData = danhSachSan.GetRange(startIndex, endIndex - startIndex);

            pCourtList.Controls.Clear();
            pCourtList.ColumnCount = 4;
            pCourtList.RowCount = 2;
            pCourtList.ColumnStyles.Clear();
            pCourtList.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                pCourtList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pCourtList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int index = 0;
            foreach (CourtDTO courtDTO in pageData)
            {
                var panel = CreateCourtPanel(courtDTO);
                int row = index / 4;
                int col = index % 4;
                pCourtList.Controls.Add(panel, col, row);
                index++;
            }

            UpdatePaginationButtons();
        }

        private void UpdatePaginationButtons()
        {
            previousButton.Enabled = currentPage > 1;
            extraPreviousButton.Enabled = currentPage > 1;
            nextButton.Enabled = currentPage < totalPages;
            extraNextButton.Enabled = currentPage < totalPages;
        }

        private void extraPreviousButton_Click(object sender, EventArgs e)
        {
            LoadCourts(currentList, 1);
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                LoadCourts(currentList, currentPage - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
                LoadCourts(currentList, currentPage + 1);
        }

        private void extraNextButton_Click(object sender, EventArgs e)
        {
            LoadCourts(currentList, totalPages);
        }
        // =================================================

        private void pCourtList_Paint(object sender, PaintEventArgs e) { }

        private CustomPanel CreateCourtPanel(CourtDTO courtDTO)
        {
            // Lấy danh sách booking theo filter
            var bookingFilterList = Filter();

            // Booking thuộc sân này + lọc theo thời gian
            var filteredBookingsByCourt = bookingFilterList
                .Where(b => b.CourtId == courtDTO.CourtId)
                .OrderBy(b => b.StartTime)
                .ToList();

            // ================== CHỌN MÀU BACKGROUND ==================
            Color bgColor;

            if (filteredBookingsByCourt.Count > 0)
            {
                var bookingStatus = filteredBookingsByCourt.First().Status;

                bgColor = bookingStatus switch
                {
                    BookingDTO.Option.playing => Color.FromArgb(255, 112, 102),
                    BookingDTO.Option.successful => Color.FromArgb(167, 216, 255),
                    _ => Color.FromArgb(200, 250, 214),
                };
            }
            else
            {
                bgColor = Color.FromArgb(200, 250, 214);
            }

            // ================== TẠO PANEL SÂN ==================
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = bgColor,
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tlCourt = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3
            };

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));

            // ===== TÊN SÂN =====
            var lblName = new Label
            {
                Text = courtDTO.CourtName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ================== DANH SÁCH BOOKING CĂN GIỮA ==================
            var pnlBookingList = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(5)
            };

            if (filteredBookingsByCourt.Count > 0)
            {
                // TableLayoutPanel giữ danh sách Booking
                var tbl = new TableLayoutPanel
                {
                    AutoSize = true,
                    ColumnCount = 1
                };

                tbl.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));

                var lblTitle = new Label
                {
                    Text = $"Tình trạng: ({filteredBookingsByCourt.Count} booking)",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 5),
                    TextAlign = ContentAlignment.MiddleCenter
                };
                tbl.Controls.Add(lblTitle);

                foreach (var booking in filteredBookingsByCourt)
                {
                    var lblBooking = new Label
                    {
                        Text = $"• {booking.StartTime:dd/MM/yyyy HH:mm} - {booking.EndTime:HH:mm}",
                        Font = new Font("Segoe UI", 8.5F),
                        AutoSize = true,
                        Margin = new Padding(0, 2, 0, 2),
                        TextAlign = ContentAlignment.MiddleCenter
                    };
                    tbl.Controls.Add(lblBooking);
                }

                var wrapper = new Panel
                {
                    AutoSize = true
                };
                wrapper.Controls.Add(tbl);

                pnlBookingList.Controls.Add(wrapper);

                pnlBookingList.Resize += (s, e) =>
                {
                    wrapper.Left = (pnlBookingList.Width - wrapper.Width) / 2;
                    wrapper.Top = (pnlBookingList.Height - wrapper.Height) / 2 + 30 - filteredBookingsByCourt.Count*10;
                };
            }
            else
            {
                var lblEmpty = new Label
                {
                    Text = "Tình trạng: Trống\nKhông có booking trong thời gian này",
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9F),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Green
                };
                pnlBookingList.Controls.Add(lblEmpty);
            }

            var buttonWrapper = new Panel
            {
                Dock = DockStyle.Fill
            };

            var btnBooking = new Button
            {
                Text = "Đặt sân",
                Width = 200,
                Height = 40,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.None
            };

            bool courtBusy = filteredBookingsByCourt.Any(b =>
                b.Status == BookingDTO.Option.playing ||
                (b.Status == BookingDTO.Option.successful &&
                 !(btnTimeFinish.SelectedTime <= b.StartTime || btnTimeStart.SelectedTime >= b.EndTime))
            );

            if (courtBusy)
            {
                btnBooking.Enabled = false;
                btnBooking.BackColor = Color.Gray;
            }

            buttonWrapper.Controls.Add(btnBooking);

            buttonWrapper.Resize += (s, e) =>
            {
                btnBooking.Left = (buttonWrapper.Width - btnBooking.Width) / 2;
                btnBooking.Top = (buttonWrapper.Height - btnBooking.Height) / 2;
            };

            btnBooking.Click += (s, e) =>
            {
                // === Validate giờ ===
                if (!TimeOnly.TryParse(lbltimeStart.Text, out TimeOnly startTime) ||
                    !TimeOnly.TryParse(lbltimeFinish.Text, out TimeOnly endTime))
                {
                    MessageBox.Show("Giờ không hợp lệ! Định dạng phải HH:mm.");
                    return;
                }

                // Giờ kết thúc < giờ bắt đầu
                if (endTime <= startTime)
                {
                    MessageBox.Show("Giờ kết thúc phải lớn hơn giờ bắt đầu!");
                    return;
                }

                // Phút hợp lệ
                int[] allowedMinutes = { 0, 15, 30, 45 };
                if (!allowedMinutes.Contains(startTime.Minute) || !allowedMinutes.Contains(endTime.Minute))
                {
                    MessageBox.Show("Phút chỉ được phép: 00, 15, 30 hoặc 45!");
                    return;
                }

                // === Validate ngày giờ không được trong quá khứ ===
                // === Validate ngày ===
                DateTime tempDate;
                if (!DateTime.TryParseExact(
                        lblDate.Text,
                        "dd/MM/yyyy",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None,
                        out tempDate))
                {
                    MessageBox.Show("Ngày không hợp lệ!");
                    return;
                }

                // chuyển sang DateOnly
                DateOnly bookingDate = DateOnly.FromDateTime(tempDate);

                // tạo DateTime start
                DateTime bookingStart = new DateTime(
                    bookingDate.Year,
                    bookingDate.Month,
                    bookingDate.Day,
                    startTime.Hour,
                    startTime.Minute,
                    0
                );

                // kiểm tra quá khứ
                if (bookingStart <= DateTime.Now)
                {
                    MessageBox.Show("Không được đặt vào thời gian trong quá khứ!");
                    return;
                }

                // === Mở giao diện đặt sân ===
                this.Controls.Clear();
                var bookingCourtDetailGUI = new BookCourtDetailGUI(
                    currentAccount,
                    courtDTO,
                    lblDate.Text,
                    lbltimeStart.Text,
                    lbltimeFinish.Text
                );
                bookingCourtDetailGUI.Dock = DockStyle.Fill;
                this.Controls.Add(bookingCourtDetailGUI);
            };

            // ================== ADD TO LAYOUT ==================
            tlCourt.Controls.Add(lblName, 0, 0);
            tlCourt.Controls.Add(pnlBookingList, 0, 1);
            tlCourt.Controls.Add(buttonWrapper, 0, 2);

            panel.Controls.Add(tlCourt);
            return panel;
        }





        private List<BookingDTO> Filter()
        {
            List<BookingDTO> bookingFilterList = new List<BookingDTO>();
            try
            {
                // 1. Lấy ngày từ label (dd/MM/yyyy)
                DateOnly bookingDate = DateOnly.ParseExact(
                    lblDate.Text,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture
                );

                // 2. Lấy giờ bắt đầu
                TimeOnly startTime = TimeOnly.ParseExact(
                    lbltimeStart.Text,
                    "HH:mm",
                    CultureInfo.InvariantCulture
                );

                // 3. Lấy giờ kết thúc
                TimeOnly endTime = TimeOnly.ParseExact(
                    lbltimeFinish.Text,
                    "HH:mm",
                    CultureInfo.InvariantCulture
                );

                // 4. Lọc theo ngày và thời gian

                bookingFilterList = bookingBUS.Filter(bookingDate, startTime, endTime);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi Filter(): " + ex.Message);
            }

            return bookingFilterList;
        }

        private void lbltimeFinish_Click(object sender, EventArgs e)
        {

        }
    }
}
