using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.GUI;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GUI
{
    public partial class AccountModifyGUI : Form
    {
        private AccountBUS accountBUS = new AccountBUS();
        private AccountDTO currentAccount;

        public AccountModifyGUI(AccountDTO account)
        {
            InitializeComponent();
            this.currentAccount = account;
            LoadPermissionData();
            LoadEmployeeData();
            FillData();
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
            try
            {
                EmployeeBUS employeeBUS = new EmployeeBUS();
                List<EmployeeDTO> dataSource = new List<EmployeeDTO>();

                if (!string.IsNullOrEmpty(currentAccount.EmployeeId))
                {
                    EmployeeDTO currentEmp = employeeBUS.GetEmployeeById(currentAccount.EmployeeId);
                    if (currentEmp != null)
                    {
                        dataSource.Add(currentEmp);
                    }
                }

                List<EmployeeDTO> availableEmployees = employeeBUS.GetAllEmployeesNotHaveAccount();

                if (availableEmployees != null && availableEmployees.Count > 0)
                {
                    dataSource.AddRange(availableEmployees);
                    comboBoxEmployeeName.Enabled = true;
                }
                else
                {
                    comboBoxEmployeeName.Enabled = false;
                }

                comboBoxEmployeeName.DataSource = dataSource;
                comboBoxEmployeeName.DisplayMember = "EmployeeName";
                comboBoxEmployeeName.ValueMember = "EmployeeId";

                if (!string.IsNullOrEmpty(currentAccount.EmployeeId))
                {
                    comboBoxEmployeeName.SelectedValue = currentAccount.EmployeeId;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách nhân viên: " + ex.Message);
            }
        }

        private void FillData()
        {
            textBoxUsername.Text = currentAccount.Username;
            textBoxUsername.ReadOnly = true;

            comboBoxPermission.SelectedValue = currentAccount.PermissionId;
            comboBoxEmployeeName.SelectedValue = currentAccount.EmployeeId;
            textBoxPassword.Text = currentAccount.Password;
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            string inputPassword = textBoxPassword.Text.Trim();
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

            AccountDTO updateAccount = new AccountDTO(currentAccount.Username, inputPassword, permissionId, 0, employeeId);
            Dictionary<string, string> errors = accountBUS.ValidateAccount(updateAccount);

            if (errors.Count > 0)
            {
                if (errors.ContainsKey("Username"))
                    errorProvider1.SetError(labelUsername, errors["Username"]);
                if (errors.ContainsKey("Password"))
                    errorProvider1.SetError(labelPassword, errors["Password"]);
                return;
            }

            try
            {
                if (accountBUS.UpdateAccount(updateAccount))
                {
                    MessageBox.Show("Cập nhật tài khoản thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (Session.CurrentUser.Username == currentAccount.Username)
                    {
                        Session.CurrentUser = updateAccount;
                        Session.TriggerPermissionChange();
                    }
                    this.currentAccount = updateAccount;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}