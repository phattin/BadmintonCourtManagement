using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountAddGUI : Form
    {
        private AccountBUS accountBUS = new AccountBUS();
        public AccountDTO NewAccount { get; private set; }

        public AccountAddGUI()
        {
            InitializeComponent();
            LoadPermissionData();
            LoadEmployeeData();
        }

        private void LoadPermissionData()
        {
            PermissionBUS permissionBUS = new PermissionBUS();
            List<PermissionDTO> permissions = permissionBUS.GetAllPermissions();

            comboBoxPermission.DataSource = permissions;
            comboBoxPermission.DisplayMember = "PermissionName";
            comboBoxPermission.ValueMember = "PermissionId";
        }

        private void LoadEmployeeData()
        {
            EmployeeBUS employeeBUS = new EmployeeBUS();
            List<EmployeeDTO> employees = employeeBUS.GetAllEmployeesNotHaveAccount();
            if (employees == null || employees.Count == 0)
            {
                employees = new List<EmployeeDTO>();
                EmployeeDTO dummyEmployee = new EmployeeDTO();
                dummyEmployee.EmployeeName = "-- Không còn nhân viên --";
                dummyEmployee.EmployeeId = "";
                employees.Add(dummyEmployee);
                comboBoxEmployeeName.Enabled = false;
            }
            else
            {
                comboBoxEmployeeName.Enabled = true;
            }
            comboBoxEmployeeName.DataSource = employees;
            comboBoxEmployeeName.DisplayMember = "EmployeeName"; 
            comboBoxEmployeeName.ValueMember = "EmployeeId";   
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string username = textBoxUsername.Text.Trim();
            string password = textBoxPassword.Text.Trim();
            string permissionId = "";
            if (comboBoxPermission.SelectedValue != null)
            {
                permissionId = comboBoxPermission.SelectedValue.ToString();
            }
            string employeeId = "";
            if (comboBoxEmployeeName.SelectedValue != null)
            {
                employeeId = comboBoxEmployeeName.SelectedValue.ToString();
            }

            AccountDTO newAccount = new AccountDTO(username, password, permissionId, 0, employeeId);
            Dictionary<string, string> errors = accountBUS.ValidateAccount(newAccount);

            if (errors.Count > 0)
            {
                if (errors.ContainsKey("Username"))
                {
                    errorProvider1.SetError(labelUsername, errors["Username"]);
                }
                if (errors.ContainsKey("Password"))
                {
                    errorProvider1.SetError(labelPassword, errors["Password"]);
                }
                if (errors.ContainsKey("EmployeeName"))
                {
                    errorProvider1.SetError(labelEmployeeName, errors["EmployeeName"]);
                }
                return;
            }

            try
            {
                if (accountBUS.InsertAccount(newAccount))
                {
                    MessageBox.Show("Thêm tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NewAccount = newAccount;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("đã tồn tại"))
                {
                    MessageBox.Show("Tên tài khoản này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}