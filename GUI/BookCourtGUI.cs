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
            // TÌM KIẾM CHỈ TRONG SÂN HOẠT ĐỘNG
            string keyword = textBox1.Text.Trim();
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
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged_1(object sender, EventArgs e) { }
        private void draft_panel_Paint(object sender, PaintEventArgs e) { }
        private void btnTimeStart_Load(object sender, EventArgs e) { }

        private void btnTimeStart_ValueChanged(object sender, EventArgs e)
        {
            lbltimeStart.Text = btnTimeStart.SelectedTime.ToString("HH:mm");
        }

        private void btnTimeFinish_Load(object sender, EventArgs e) { }

        private void btnTimeFinish_ValueChanged(object sender, EventArgs e)
        {
            lbltimeFinish.Text = btnTimeFinish.SelectedTime.ToString("HH:mm");
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
            List<BookingDTO> successfulBookingList = bookingBUS.GetSuccessfulBookingsByCourtID(courtDTO.CourtId);
            bool hasBooking = successfulBookingList.Count > 0;

            var panel = new CustomPanel
            {
                BorderRadius = 10,
                // Đỏ nếu có booking, xanh lá nếu trống
                BackColor = hasBooking ? Color.FromArgb(255, 176, 163) : Color.FromArgb(200, 250, 214),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tlCourt = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3
            };

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));  // Tên sân
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 70F));  // Danh sách booking (tăng lên)
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));  // Nút đặt sân

            // ========== TÊN SÂN ==========
            var lblName = new Label
            {
                Text = courtDTO.CourtName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // ========== DANH SÁCH BOOKING ==========
            var pnlBookingList = new Panel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                Padding = new Padding(5)
            };

            if (hasBooking)
            {
                // Sắp xếp booking theo thời gian
                var sortedBookings = successfulBookingList.OrderBy(b => b.StartTime).ToList();

                // Tạo FlowLayoutPanel để hiển thị danh sách booking
                var flowLayout = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false,
                    AutoScroll = true,
                    Padding = new Padding(5)
                };

                // Thêm tiêu đề
                var lblTitle = new Label
                {
                    Text = $"Tình trạng: Đã đặt ({sortedBookings.Count} booking)",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    AutoSize = true,
                    ForeColor = Color.DarkRed
                };
                flowLayout.Controls.Add(lblTitle);

                // Thêm từng booking
                foreach (var booking in sortedBookings)
                {
                    var lblBooking = new Label
                    {
                        Text = $"• {booking.StartTime:dd/MM/yyyy HH:mm} - {booking.EndTime:HH:mm}",
                        Font = new Font("Segoe UI", 8.5F),
                        AutoSize = true,
                        Padding = new Padding(10, 2, 0, 2)
                    };
                    flowLayout.Controls.Add(lblBooking);
                }

                pnlBookingList.Controls.Add(flowLayout);
            }
            else
            {
                // Không có booking
                var lblEmpty = new Label
                {
                    Text = "Tình trạng: Trống\nChưa có booking nào",
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 9F),
                    TextAlign = ContentAlignment.MiddleCenter,
                    ForeColor = Color.Green
                };
                pnlBookingList.Controls.Add(lblEmpty);
            }

            // ========== NÚT ĐẶT SÂN ==========
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

            // ========== THÊM VÀO LAYOUT ==========
            tlCourt.Controls.Add(lblName, 0, 0);
            tlCourt.Controls.Add(pnlBookingList, 0, 1);
            tlCourt.Controls.Add(btnBooking, 0, 2);

            panel.Controls.Add(tlCourt);

            return panel;
        }
    }
}
