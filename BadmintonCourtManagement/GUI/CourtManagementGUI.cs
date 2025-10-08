using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class CourtManagementGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtBUS courtBUS;
        private BookingBUS bookingBUS;
        public CourtManagementGUI()
        {
            InitializeComponent();
        }

        public CourtManagementGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            courtBUS = new CourtBUS();
            bookingBUS = new BookingBUS();
            List<CourtDTO> courts = courtBUS.GetAllCourts();
            LoadCourts(courts);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CourtManagementGUI_Load(object sender, EventArgs e)
        {

        }

        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btncourtDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sân này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa sân
                MessageBox.Show("Xóa sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

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

        private void ReloadCourtList()
        {
            List<CourtDTO> danhSachSan = courtBUS.GetAllCourts();
            LoadCourts(danhSachSan);
        }


        private CustomPanel CreateCourtPanel(CourtDTO courtDTO)
        {
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
                RowCount = 4
            };

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Mã sân
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Tên sân
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Trạng thái
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));  // Nút

            // Label mã sân
            var lblID = new Label
            {
                Text = courtDTO.CourtId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Label tên sân
            var lblName = new Label
            {
                Text = "Tên sân: " + courtDTO.CourtName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Label trạng thái
            string statusText = courtDTO.Status == CourtDTO.Option.active ? "Hoạt động" : "Ngừng hoạt động";
            var lblStatus = new Label
            {
                Text = "Trạng thái: " + statusText,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Panel chứa hai nút
            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Padding = new Padding(0, 5, 0, 5),
                Margin = new Padding(0),
                AutoSizeMode = AutoSizeMode.GrowAndShrink
            };

            // Nút Xóa
            var btnDelete = new Button
            {
                Text = "Xóa",
                Width = 70,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            // Nút Sửa
            var btnEdit = new Button
            {
                Text = "Sửa",
                Width = 70,
                Height = 35,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(10, 0, 10, 0)
            };

            // Sự kiện Xóa
            // Sự kiện Xóa
            btnDelete.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa sân '{courtDTO.CourtName}' không?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        bool isDeleted = courtBUS.DeleteCourt(courtDTO.CourtId);

                        if (isDeleted)
                        {
                            MessageBox.Show("Xóa sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ReloadCourtList(); // Cập nhật lại danh sách
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sân này (có thể đang được đặt hoặc lỗi cơ sở dữ liệu).", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };


            // Sự kiện Sửa
            btnEdit.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty, // bỏ tiêu đề
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(450, 450),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var editCourtGUI = new EditCourtGUI(courtDTO);
                editCourtGUI.Dock = DockStyle.Fill;

                dialog.Controls.Add(editCourtGUI);

                dialog.ShowDialog();

                ReloadCourtList(); // reload danh sách sau khi đóng dialog
            };


            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            // Thêm tất cả control vào TableLayoutPanel
            tlCourt.Controls.Add(lblID, 0, 0);
            tlCourt.Controls.Add(lblName, 0, 1);
            tlCourt.Controls.Add(lblStatus, 0, 2);
            tlCourt.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tlCourt);

            return panel;
        }


        private void pCourtList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
