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

                if (permissions.Count > 0) comboBoxPermission.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách quyền: " + ex.Message);
            }
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

            AccountDTO newAccount = new AccountDTO(username, password, permissionId, 0);
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