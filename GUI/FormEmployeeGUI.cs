using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormEmployeeGUI : UserControl
    {
        private string mode; // Insert / Update
        private string employeeId;
        private AccountDTO currentAccount;

        private EmployeeBUS employeeBUS = new EmployeeBUS();
        private RoleBUS roleBUS = new RoleBUS();

        private List<RoleDTO> roleList;

        public FormEmployeeGUI(string mode, string employeeId, AccountDTO currentAccount)
        {
            this.mode = mode;
            this.employeeId = employeeId;
            this.currentAccount = currentAccount;

            InitializeComponent();

            EmployeeID.Text = employeeId;

            // --- LOAD ROLE ---
            roleList = roleBUS.GetAllRoles();
            RoleOption.Items.Clear();
            foreach (var r in roleList)
                RoleOption.Items.Add(r.RoleName);

            if (RoleOption.Items.Count > 0)
                RoleOption.SelectedIndex = 0;

            // --- INSERT MODE ---
            if (mode == "Insert")
            {
                Title.Text = "Thêm nhân viên";
                txtEmployeeName.Text = "";
                txtEmployeeSDT.Text = "";
                txtEmployeeAddress.Text = "";
            }
            // --- UPDATE MODE ---
            else // Update
            {
                Title.Text = "Sửa nhân viên";

                var emp = employeeBUS.GetEmployeeById(employeeId);
                if (emp != null)
                {
                    txtEmployeeName.Text = emp.EmployeeName;
                    txtEmployeeSDT.Text = emp.EmployeePhone;
                    txtEmployeeAddress.Text = emp.Address;

                    var role = roleList.Find(r => r.RoleId == emp.RoleId);
                    if (role != null)
                        RoleOption.SelectedItem = role.RoleName;
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtEmployeeName.Text.Trim() == "")
            {
                MessageBox.Show("Tên nhân viên không được để trống!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtEmployeeSDT.Text.Trim() == "")
            {
                MessageBox.Show("Số điện thoại không được để trống!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string name = txtEmployeeName.Text.Trim();
            string phone = txtEmployeeSDT.Text.Trim();
            string address = txtEmployeeAddress.Text.Trim();

            // Lấy RoleId từ RoleName – kiểm tra null
            if (RoleOption.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn vai trò cho nhân viên!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string selectedRoleName = RoleOption.SelectedItem.ToString();
            string selectedRoleId = roleList.Find(r => r.RoleName == selectedRoleName)?.RoleId;

            if (selectedRoleId == null)
            {
                MessageBox.Show("Vai trò không hợp lệ!",
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var emp = new EmployeeDTO(
                employeeId,
                name,
                phone,
                address,
                selectedRoleId
            );

            // ---- THÊM MỚI ----  
            if (mode == "Insert")
            {
                if (employeeBUS.InsertEmployee(emp))
                {
                    MessageBox.Show("Thêm nhân viên thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Thêm nhân viên thất bại! Vui lòng kiểm tra lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            // ---- CẬP NHẬT ----
            else if (mode == "Update")
            {
                if (employeeBUS.UpdateEmployee(emp))
                {
                    MessageBox.Show("Cập nhật nhân viên thành công!",
                        "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cập nhật nhân viên thất bại! Vui lòng kiểm tra lại.",
                        "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();
        }
    }
}
