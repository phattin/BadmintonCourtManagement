using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.ComponentModel;

namespace GUI
{
    public partial class AccountGUI : UserControl
    {
        private AccountDTO currentAccount;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private AccountBUS accountBUS = new AccountBUS();
        private BindingList<AccountDTO> accountList;
        private BindingList<AccountDTO> displayList;
        private bool isInsert = false, isUpdate = false, isDelete = false;
        private Dictionary<string, string> permissionMap = new Dictionary<string, string>();
        private Dictionary<string, string> employeeMap = new Dictionary<string, string>();
        public AccountGUI(AccountDTO account)
        {
            this.currentAccount = account;
            InitializeComponent();
            CheckPermissions("F10");
            LoadMaps();
            ConfigureDataGridView();
            LoadData();
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

            buttonAdd.Visible = isInsert;
            buttonModify.Visible = isUpdate;
            buttonDelete.Visible = isDelete;
        }
        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            if (dataGridView1.Columns.Contains("Username"))
                dataGridView1.Columns["Username"].DataPropertyName = "Username";

            if (dataGridView1.Columns.Contains("Password"))
                dataGridView1.Columns["Password"].DataPropertyName = "Password";

            if (dataGridView1.Columns.Contains("PermissionId"))
                dataGridView1.Columns["PermissionId"].DataPropertyName = "PermissionId";

            if (dataGridView1.Columns.Contains("EmployeeName"))
                dataGridView1.Columns["EmployeeName"].DataPropertyName = "EmployeeId";

            if (dataGridView1.Columns.Contains("Status"))
                dataGridView1.Columns["Status"].DataPropertyName = "IsDeleted";

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }
        private void LoadMaps()
        {
            permissionMap.Clear();
            employeeMap.Clear();
            PermissionBUS pBus = new PermissionBUS();
            foreach (var p in pBus.GetAllPermissions())
            {
                permissionMap[p.PermissionId] = p.PermissionName;
            }
            EmployeeBUS eBus = new EmployeeBUS();
            foreach (var e in eBus.GetAllEmployees())
            {
                employeeMap[e.EmployeeId] = e.EmployeeName;
            }
        }
        public void LoadData()
        {
            LoadMaps();
            try
            {
                var list = accountBUS.GetAllAccount1();
                accountList = new BindingList<AccountDTO>(list);
                displayList = new BindingList<AccountDTO>(list);
                dataGridView1.DataSource = displayList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }
        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "PermissionId")
            {
                string id = e.Value.ToString();
                if (permissionMap.ContainsKey(id))
                {
                    e.Value = permissionMap[id];
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "EmployeeName")
            {
                string id = e.Value.ToString();
                if (employeeMap.ContainsKey(id))
                {
                    e.Value = employeeMap[id];
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                int isDeleted = Convert.ToInt32(e.Value);
                if (isDeleted == 0)
                {
                    e.Value = "Đang hoạt động";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Ngưng hoạt động";
                    e.CellStyle.ForeColor = Color.Red;
                }
                e.FormattingApplied = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AccountAddGUI addForm = new AccountAddGUI();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var selectedItem = selectedRow.DataBoundItem as AccountDTO;

            if (selectedItem == null) return;

            if (selectedItem.Username == currentAccount.Username)
            {
                MessageBox.Show("Bạn không thể sửa tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (selectedItem.IsDeleted == 1)
            {
                MessageBox.Show("Tài khoản này đã bị xóa, không thể chỉnh sửa.", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            AccountModifyGUI modifyForm = new AccountModifyGUI(selectedItem);

            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn tài khoản để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var selectedItem = selectedRow.DataBoundItem as AccountDTO;

            if (selectedItem == null) return;

            if (selectedItem.Username == currentAccount.Username)
            {
                MessageBox.Show("Bạn không thể xóa tài khoản đang đăng nhập!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa tài khoản này không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    EmployeeBUS employeeBUS = new EmployeeBUS();
                    if (accountBUS.DeleteAccount(selectedItem.Username))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        EmployeeDTO currentEmployee = employeeBUS.GetEmployeeById(selectedItem.EmployeeId);
                        EmployeeDTO updateEmployee = new EmployeeDTO
                        {
                            EmployeeId = currentEmployee.EmployeeId,
                            EmployeeName = currentEmployee.EmployeeName,
                            EmployeePhone = currentEmployee.EmployeePhone,
                            Address = currentEmployee.Address,
                            RoleId = currentEmployee.RoleId,
                        };
                        employeeBUS.UpdateEmployee(updateEmployee);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string keyword = textBox1.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dataGridView1.DataSource = new BindingList<AccountDTO>(accountList);
                return;
            }

            var filteredData = accountList.Where(acc =>
            {
                bool matchUsername = acc.Username != null && acc.Username.ToLower().Contains(keyword);
                string permName = "";
                if (acc.PermissionId != null && permissionMap.ContainsKey(acc.PermissionId))
                {
                    permName = permissionMap[acc.PermissionId];
                }
                bool matchPermissionName = permName.ToLower().Contains(keyword);
                string empName = "";
                if (acc.EmployeeId != null && employeeMap.ContainsKey(acc.EmployeeId))
                {
                    empName = employeeMap[acc.EmployeeId];
                }
                bool matchEmployeeName = empName.ToLower().Contains(keyword);
                string statusText = acc.IsDeleted == 0 ? "đang hoạt động" : "ngưng hoạt động";
                bool matchStatus = statusText.Contains(keyword);
                return matchUsername || matchPermissionName || matchEmployeeName || matchStatus;

            }).ToList();
            dataGridView1.DataSource = new BindingList<AccountDTO>(filteredData);
        }
    }
}