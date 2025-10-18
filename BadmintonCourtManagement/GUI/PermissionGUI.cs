using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.Runtime.CompilerServices;

namespace BadmintonCourtManagement.GUI
{
    public partial class PermissionGUI : UserControl
    {
        private AccountDTO currentAccount;
        private PermissionBUS permissionBUS = new PermissionBUS();
        private List<PermissionDTO> currentList = new List<PermissionDTO>();
        private int currentPage;
        private int itemsPerPage;
        private int totalPages;
        public PermissionGUI(AccountDTO currentAccount)
        {
            InitializeComponent();
            this.currentAccount = currentAccount;
            currentPage = 1;
            itemsPerPage = 8;
            totalPages = 1;
            ReloadList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            currentList = permissionBUS.Search(txtSearch.Text);
            LoadPermission(currentList, 1);
        }

        private void LoadPermission(List<PermissionDTO> danhSach, int pageNumber)
        {
            totalPages = (int)Math.Ceiling((double)danhSach.Count / itemsPerPage);
            if (totalPages == 0) totalPages = 1;
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
            int endIndex = Math.Min(startIndex + itemsPerPage, danhSach.Count);
            var pageData = danhSach.GetRange(startIndex, endIndex - startIndex);

            pList.Controls.Clear();
            pList.ColumnCount = 4;
            pList.RowCount = 2;
            pList.ColumnStyles.Clear();
            pList.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                pList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int index = 0;
            foreach (PermissionDTO permissionDTO in pageData)
            {
                var panel = CreateCourtPanel(permissionDTO);
                int row = index / 4;
                int col = index % 4;
                pList.Controls.Add(panel, col, row);
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

        private void pList_Paint(object sender, PaintEventArgs e)
        {

        }
        private CustomPanel CreateCourtPanel(PermissionDTO permissionDTO)
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

            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 40F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlCourt.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tlCourt.Padding = new Padding(10);

            // Label mã
            var lblName = new Label
            {
                Text = permissionDTO.PermissionId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 20, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };
            // Label thông tin
            var lblInfo = new Label
            {
                Text = permissionDTO.PermissionName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16F),
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Nút Xem chi tiết
            var btnView = new Button
            {
                Text = "Xem chi tiết",
                Width = 200,
                Height = 43,
                Anchor = AnchorStyles.Bottom,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0, 0, 0, 10)
            };

            // Nút sửa
            var btnUpdate = new Button
            {
                Text = "Sửa",
                Width = 200,
                Height = 43,
                Anchor = AnchorStyles.Bottom,
                BackColor = Color.FromArgb(64, 64, 64),
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                FlatStyle = FlatStyle.Flat,
                Margin = new Padding(0, 0, 0, 10)
            };

            btnView.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty, // bỏ tiêu đề
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(900, 900),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var formPermissionGUI = new FormPermissionGUI("View", permissionDTO.PermissionId, currentAccount);
                formPermissionGUI.Dock = DockStyle.Fill;

                dialog.Controls.Add(formPermissionGUI);

                dialog.ShowDialog();
            };

            btnUpdate.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    Text = string.Empty, // bỏ tiêu đề
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(900, 900),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };
                var formPermissionGUI = new FormPermissionGUI("Update", permissionDTO.PermissionId, currentAccount);
                formPermissionGUI.Dock = DockStyle.Fill;
                dialog.Controls.Add(formPermissionGUI);
                dialog.ShowDialog();
                ReloadList();
            };

            tlCourt.Controls.Add(lblName, 0, 0);
            tlCourt.Controls.Add(lblInfo, 0, 1);
            tlCourt.Controls.Add(btnView, 0, 2);
            tlCourt.Controls.Add(btnUpdate, 0, 3);

            panel.Controls.Add(tlCourt);

            return panel;
        }

        private void pList_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            Form dialog = new Form()
            {
                Text = string.Empty, // bỏ tiêu đề
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(900, 900),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var insertPermissionGUI = new FormPermissionGUI("Insert", permissionBUS.GetNextId(), currentAccount);
            insertPermissionGUI.Dock = DockStyle.Fill;

            dialog.Controls.Add(insertPermissionGUI);

            dialog.ShowDialog();

            ReloadList(); // reload danh sách sau khi đóng dialog
        }

        private void ReloadList()
        {
            currentList = permissionBUS.GetAllPermissions();
            LoadPermission(currentList, 1);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            ReloadList();
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                LoadPermission(currentList, currentPage - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
                LoadPermission(currentList, currentPage + 1);
        }

        private void extraPreviousButton_Click(object sender, EventArgs e)
        {
            LoadPermission(currentList, 1);
        }

        private void extraNextButton_Click(object sender, EventArgs e)
        {
            LoadPermission(currentList, totalPages);
        }
    }
}
