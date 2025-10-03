using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.Runtime.InteropServices;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtGUI : UserControl
    {
        private AccountDTO currentAccount;

        public BookCourtGUI(AccountDTO account)
        {
            // AccountDTO accountCurrent = account;
            currentAccount = account;
            InitializeComponent();
            var danhSachSan = new List<string>
            {
                "Sân A", "Sân B", "Sân C", "Sân D",
                "Sân E", "Sân F", "Sân G", "Sân H"
            };

            LoadCourts(danhSachSan);
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


        private void btnBooking2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var detailGUI = new BookCourtDetailGUI(currentAccount);
            detailGUI.Dock = DockStyle.Fill;
            this.Controls.Add(detailGUI);
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

        private void pCourtList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCourtList_Resize(object sender, EventArgs e)
        {
            int soSanMoiDong = 4;
            int panelWidth = pCourtList.ClientSize.Width / soSanMoiDong - 15;
            int panelHeight = pCourtList.ClientSize.Height / 2 - 20;

            foreach (Control ctrl in pCourtList.Controls)
            {
                if (ctrl is CustomPanel panel)
                {
                    panel.Width = panelWidth;
                    panel.Height = panelHeight;
                }
            }
        }


        private void LoadCourts(List<string> danhSachSan)
        {
            pCourtList.Controls.Clear(); // Xóa các sân cũ nếu có

            int soSanMoiDong = 4;
            int panelWidth = pCourtList.ClientSize.Width / soSanMoiDong - 15; // trừ padding/margin
            int panelHeight = pCourtList.ClientSize.Height / 2 - 20; // trừ padding/margin

            foreach (var courtName in danhSachSan)
            {

                var panel = new CustomPanel
                {
                    Width = panelWidth,
                    Height = panelHeight,
                    BorderRadius = 10,
                    BackColor = Color.FromArgb(200, 250, 214),
                    Margin = new Padding(5)
                };

                // Label tên sân
                var lblName = new Label
                {
                    Text = courtName,
                    AutoSize = true,
                    Font = new Font("Segoe UI", 13.8F, FontStyle.Bold),
                    Location = new Point(60, 10)
                };
                panel.Controls.Add(lblName);

                // Label thông tin
                var lblInfo = new Label
                {
                    Text = "Tình trạng: Trống\nBooking tiếp theo: 7h-9h",
                    AutoSize = true,
                    Location = new Point(20, 70),
                    Font = new Font("Segoe UI", 9F)
                };
                panel.Controls.Add(lblInfo);

                // Nút đặt sân
                var btnBooking = new Label
                {
                    Text = "Đặt sân",
                    AutoSize = true,
                    BackColor = Color.FromArgb(64, 64, 64),
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Cursor = Cursors.Hand,
                    Padding = new Padding(10, 8, 10, 8),
                    Location = new Point(70, 130)
                };
                btnBooking.Click += (s, e) =>
                {
                    MessageBox.Show($"Bạn vừa đặt {courtName}");
                };
                panel.Controls.Add(btnBooking);

                // Thêm panel vào danh sách
                pCourtList.Controls.Add(panel);
            }
        }



    }
}
