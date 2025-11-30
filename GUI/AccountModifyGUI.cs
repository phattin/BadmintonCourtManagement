using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

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
            FillData();
        }

        private void LoadPermissionData()
        {
            try
            {
                PermissionBUS permissionBUS = new PermissionBUS();
                List<PermissionDTO> permissions = permissionBUS.GetAllPermissions();

                comboBoxPermission.DataSource = permissions;
                comboBoxPermission.DisplayMember = "PermissionName";
                comboBoxPermission.ValueMember = "PermissionId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quyền: " + ex.Message);
            }
        }

        private void FillData()
        {
            textBoxUsername.Text = currentAccount.Username;
            textBoxUsername.ReadOnly = true;

            comboBoxPermission.SelectedValue = currentAccount.PermissionId;
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

            AccountDTO updateAccount = new AccountDTO(currentAccount.Username, inputPassword, permissionId, 0);
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