using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DAO;
using BadmintonCourtManagement.DTO;
using BadmintonCourtManagement.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    public partial class AccountGUI : UserControl
    {
        private AccountDTO currentAccount;

        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private AccountBUS accountBUS = new AccountBUS();
        private BindingList<AccountDTO> accountList;
        private bool isInsert = false, isUpdate = false, isDelete = false;
        public AccountGUI(AccountDTO account)
        {
            this.currentAccount = account;
            InitializeComponent();
            ConfigureDataGridView();
            LoadData();
            CheckPermissions("F10");
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

            if (dataGridView1.Columns.Contains("Status"))
                dataGridView1.Columns["Status"].DataPropertyName = "IsDeleted";

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }
        public void LoadData()
        {
            try
            {
                var list = accountBUS.GetAllAccount1();

                accountList = new BindingList<AccountDTO>(list);
                dataGridView1.DataSource = accountList;
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
                PermissionBUS permissionBUS = new PermissionBUS();
                List<PermissionDTO> permissions = permissionBUS.GetAllPermissions();
                foreach(var permission in permissions)
                {
                    if(permission.PermissionId == id)
                    {
                        e.Value = permission.PermissionName;
                        e.FormattingApplied = true;
                        break;
                    }
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
                $"Bạn có chắc chắn muốn xóa tài khoản này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (accountBUS.DeleteAccount(selectedItem.Username))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}