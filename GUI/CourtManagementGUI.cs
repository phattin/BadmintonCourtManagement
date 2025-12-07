using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class CourtManagementGUI : UserControl
    {
        private AccountDTO currentAccount;
        private CourtBUS courtBUS;
        private BookingBUS bookingBUS;
        private List<CourtDTO> currentList = new List<CourtDTO>();
        private int currentPage;
        private int itemsPerPage;
        private int totalPages;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;

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

            currentPage = 1;
            itemsPerPage = 8;
            totalPages = 1;
            CheckPermissions("F02");
            ReloadCourtList();
        }

        private void CheckPermissions(string functionId)
        {
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId(functionId);

            foreach (var p in permissionDetails)
            {
                if (p.PermissionId == currentAccount.PermissionId)
                {
                    if (p.Option == "Insert") isInsert = true;
                    else if (p.Option == "Update") isUpdate = true;
                    else if (p.Option == "Delete") isDelete = true;
                }
            }

            btnAdd.Visible = isInsert;
        }

        private void pictureBox1_Click(object sender, EventArgs e) { }

        private void CourtManagementGUI_Load(object sender, EventArgs e) { }

        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e) { }

        //private void btncourtDelete_Click(object sender, EventArgs e)
        //{
        //    DialogResult result = MessageBox.Show(
        //        "Bạn có chắc chắn muốn xóa sân này không?",
        //        "Xác nhận xóa",
        //        MessageBoxButtons.YesNo,
        //        MessageBoxIcon.Question
        //    );
        //    if (result == DialogResult.Yes)
        //    {
        //        MessageBox.Show("Xóa sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}

        private void LoadCourts(List<CourtDTO> danhSachSan, int pageNumber)
        {
            totalPages = (int)Math.Ceiling((double)danhSachSan.Count / itemsPerPage);
            if (totalPages == 0) totalPages = 1;

            // Ẩn/hiện nút phân trang
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

            // Hiển thị danh sách sân trong trang hiện tại
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

        private void ReloadCourtList()
        {
            currentList = courtBUS.GetAllCourts();
            LoadCourts(currentList, 1);
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

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));

            var lblID = new Label
            {
                Text = courtDTO.CourtId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblName = new Label
            {
                Text = "Tên sân: " + courtDTO.CourtName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            string statusText = courtDTO.Status == CourtDTO.Option.active ? "Hoạt động" : "Bảo trì";
            var lblStatus = new Label
            {
                Text = "Trạng thái: " + statusText,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10, FontStyle.Regular),
                TextAlign = ContentAlignment.MiddleCenter
            };

            if (courtDTO.Status == CourtDTO.Option.maintenance)
                panel.BackColor = Color.FromArgb(255, 176, 163);
            else if (courtDTO.Status == CourtDTO.Option.active)
                panel.BackColor = Color.FromArgb(200, 250, 214);

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
            btnDelete.Visible = isDelete;

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
            btnEdit.Visible = isUpdate;

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
                            ReloadCourtList();
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa sân này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Đã xảy ra lỗi khi xóa sân: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            };

            btnEdit.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(600, 600),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var editCourtGUI = new FormCourtGUI("Update", courtDTO.CourtId, currentAccount);
                editCourtGUI.Dock = DockStyle.Fill;

                dialog.Controls.Add(editCourtGUI);
                dialog.ShowDialog();

                ReloadCourtList();
            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            tlCourt.Controls.Add(lblID, 0, 0);
            tlCourt.Controls.Add(lblName, 0, 1);
            tlCourt.Controls.Add(lblStatus, 0, 2);
            tlCourt.Controls.Add(buttonPanel, 0, 3);

            panel.Controls.Add(tlCourt);

            return panel;
        }

        private void pCourtList_Paint(object sender, PaintEventArgs e) { }

        private void customPanel1_Paint(object sender, PaintEventArgs e) { }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form dialog = new Form()
            {
                Text = string.Empty,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(600, 600),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var addCourtGUI = new FormCourtGUI("Insert", courtBUS.GetNextId(), currentAccount);
            addCourtGUI.Dock = DockStyle.Fill;

            dialog.Controls.Add(addCourtGUI);
            dialog.ShowDialog();

            ReloadCourtList();
        }

        private void statusFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Kiểm tra nếu courtBUS chưa được khởi tạo (trong lúc InitializeComponent)
            if (courtBUS == null)
                return;

            string selectedStatus = statusFilter.SelectedItem?.ToString();

            // Kiểm tra nếu chưa chọn gì
            if (string.IsNullOrEmpty(selectedStatus))
                return;

            string statusCode = "all";
            if (selectedStatus == "Hoạt động")
                statusCode = "active";
            else if (selectedStatus == "Bảo trì")
                statusCode = "maintenance";

            currentList = courtBUS.FilterByStatus(statusCode);

            // Đảm bảo currentList không null
            if (currentList == null)
                currentList = new List<CourtDTO>();

            LoadCourts(currentList, 1);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            currentList = courtBUS.Search(textBox1.Text);
            LoadCourts(currentList, 1);
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
    }
}
