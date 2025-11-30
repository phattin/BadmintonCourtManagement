using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class EmployeeGUI : UserControl
    {
        private AccountDTO currentAccount;
        private EmployeeBUS employeeBUS;
        private List<EmployeeDTO> currentList = new List<EmployeeDTO>();

        private int currentPage;
        private int itemsPerPage;
        private int totalPages;

        // Constructor mặc định – KHỞI TẠO GIỐNG COURT
        public EmployeeGUI()
        {
            InitializeComponent();

            employeeBUS = new EmployeeBUS();
            currentPage = 1;
            itemsPerPage = 8;
            totalPages = 1;

            ReloadEmployeeList();
        }

        // Constructor có AccountDTO – cũng khởi tạo như trên
        public EmployeeGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();

            employeeBUS = new EmployeeBUS();
            currentPage = 1;
            itemsPerPage = 8;
            totalPages = 1;

            ReloadEmployeeList();
        }

        private void ReloadEmployeeList()
        {
            currentList = employeeBUS.GetAllEmployees();
            //MessageBox.Show("So nhan vien: " + currentList.Count);
            LoadEmployees(currentList, 1);
        }

        private void LoadEmployees(List<EmployeeDTO> list, int pageNumber)
        {
            totalPages = (int)Math.Ceiling((double)list.Count / itemsPerPage);
            if (totalPages == 0) totalPages = 1;

            previousButton.Visible = nextButton.Visible =
            extraPreviousButton.Visible = extraNextButton.Visible =
                totalPages > 1;

            if (pageNumber < 1) pageNumber = 1;
            if (pageNumber > totalPages) pageNumber = totalPages;

            currentPage = pageNumber;

            int startIndex = (pageNumber - 1) * itemsPerPage;
            int endIndex = Math.Min(startIndex + itemsPerPage, list.Count);
            var pageData = list.GetRange(startIndex, endIndex - startIndex);

            pEmployeeList.Controls.Clear();
            pEmployeeList.ColumnCount = 4;
            pEmployeeList.RowCount = 2;
            pEmployeeList.ColumnStyles.Clear();
            pEmployeeList.RowStyles.Clear();

            for (int i = 0; i < 4; i++)
                pEmployeeList.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            for (int j = 0; j < 2; j++)
                pEmployeeList.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));

            int index = 0;
            foreach (EmployeeDTO emp in pageData)
            {
                var panel = CreateEmployeePanel(emp);

                int row = index / 4;
                int col = index % 4;
                pEmployeeList.Controls.Add(panel, col, row);

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

        private CustomPanel CreateEmployeePanel(EmployeeDTO emp)
        {
            var panel = new CustomPanel
            {
                BorderRadius = 10,
                BackColor = Color.FromArgb(200, 230, 255),
                Margin = new Padding(5),
                Dock = DockStyle.Fill
            };

            var tl = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 6
            };

            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));
            tl.RowStyles.Add(new RowStyle(SizeType.Percent, 16.66F));

            var lblID = new Label
            {
                Text = emp.EmployeeId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblName = new Label
            {
                Text = "Tên: " + emp.EmployeeName,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblPhone = new Label
            {
                Text = "SĐT: " + emp.EmployeePhone,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblAddress = new Label
            {
                Text = "Địa chỉ: " + emp.Address,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var lblRole = new Label
            {
                Text = "Vai trò: " + emp.RoleId,
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 10),
                TextAlign = ContentAlignment.MiddleCenter
            };

            var buttonPanel = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
                AutoSize = true,
                Anchor = AnchorStyles.None,
                Padding = new Padding(0, 5, 0, 5)
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

            // Delete
            btnDelete.Click += (s, e) =>
            {
                DialogResult result = MessageBox.Show(
                    $"Bạn có chắc muốn xóa nhân viên '{emp.EmployeeName}'?",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    if (employeeBUS.DeleteEmployee(emp.EmployeeId))
                    {
                        MessageBox.Show("Xóa nhân viên thành công!", "Thông báo");
                        ReloadEmployeeList();
                    }
                    else
                    {
                        MessageBox.Show("Không thể xóa nhân viên!", "Lỗi");
                    }
                }
            };

            // Edit
            btnEdit.Click += (s, e) =>
            {
                Form dialog = new Form()
                {
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    StartPosition = FormStartPosition.CenterParent,
                    Size = new Size(600, 600),
                    MaximizeBox = false,
                    MinimizeBox = false,
                    ShowInTaskbar = false
                };

                var editGUI = new FormEmployeeGUI("Update", emp.EmployeeId, currentAccount);
                editGUI.Dock = DockStyle.Fill;

                dialog.Controls.Add(editGUI);
                dialog.ShowDialog();

                ReloadEmployeeList();
            };

            buttonPanel.Controls.Add(btnDelete);
            buttonPanel.Controls.Add(btnEdit);

            tl.Controls.Add(lblID, 0, 0);
            tl.Controls.Add(lblName, 0, 1);
            tl.Controls.Add(lblPhone, 0, 2);
            tl.Controls.Add(lblAddress, 0, 3);
            tl.Controls.Add(lblRole, 0, 4);
            tl.Controls.Add(buttonPanel, 0, 5);

            panel.Controls.Add(tl);

            return panel;
        }

        // Search
        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            currentList = employeeBUS.Search(textBox1.Text);
            LoadEmployees(currentList, 1);
        }

        // Add employee
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form dialog = new Form()
            {
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterParent,
                Size = new Size(600, 600),
                MaximizeBox = false,
                MinimizeBox = false,
                ShowInTaskbar = false
            };

            var addGUI = new FormEmployeeGUI("Insert", employeeBUS.GetNextId(), currentAccount);
            addGUI.Dock = DockStyle.Fill;

            dialog.Controls.Add(addGUI);
            dialog.ShowDialog();

            ReloadEmployeeList();
        }

        // Pagination
        private void previousButton_Click(object sender, EventArgs e)
        {
            if (currentPage > 1)
                LoadEmployees(currentList, currentPage - 1);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (currentPage < totalPages)
                LoadEmployees(currentList, currentPage + 1);
        }

        private void extraPreviousButton_Click(object sender, EventArgs e)
        {
            LoadEmployees(currentList, 1);
        }

        private void extraNextButton_Click(object sender, EventArgs e)
        {
            LoadEmployees(currentList, totalPages);
        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {

        }
    }
}
