using System;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using GUI;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormPermissionGUI : UserControl
    {
        private string mode; // View, Insert, Update
        private string permissionId;
        private AccountDTO currentAccount;
        private PermissionBUS permissionBUS = new PermissionBUS();
        private PermissionDetailBUS permissionDetailBUS = new PermissionDetailBUS();
        public FormPermissionGUI(string mode, string permissionId, AccountDTO currentAccount)
        {
            this.mode = mode;
            this.permissionId = permissionId;
            this.currentAccount = currentAccount;
            InitializeComponent();
            txtPermissionId.Text = permissionId;
            SetupPermissionTable();
            StyleCheckBoxes(this);
            SetupCheckboxLogic();
            if (mode != "Insert")
                loadDataCheckBox();
            if (mode == "View")
            {
                lblTitle.Text = "Chi tiết phân quyền";
                btnConfirm.Visible = false; btnCancel.Text = "Đóng";
                btnCancel.Location = new Point((this.Width - btnCancel.Width) / 2, btnCancel.Location.Y);
            }
            if (mode == "Update")
                lblTitle.Text = "Sửa phân quyền";
        }

        private void loadDataCheckBox()
        {
            // Map mã chức năng sang tên
            Dictionary<string, string> functionMap = new Dictionary<string, string>()
    {
        { "F01", "Booking" },
        { "F02", "Court" },
        { "F03", "Sell" },
        { "F04", "Bill" },
        { "F05", "Import" },
        { "F06", "Product" },
        { "F07", "Supplier" },
        { "F08", "Customer" },
        { "F09", "Employee" },
        { "F10", "Account" },
        { "F11", "Permission" },
        { "F12", "Statistic" }
    };

            // Lấy chi tiết quyền
            var permissionDetails = permissionDetailBUS.GetPermissionDetailsByPermissionId(permissionId);
            foreach (var detail in permissionDetails)
            {
                if (!functionMap.ContainsKey(detail.FunctionId)) continue;
                string tagToFind = detail.Option + functionMap[detail.FunctionId];

                foreach (Control c in tPermission.Controls)
                {
                    if (c is CheckBox cb && cb.Tag != null && cb.Tag.ToString() == tagToFind)
                    {
                        cb.Checked = true;
                    }
                }
            }

            // Load thông tin quyền
            var permission = permissionBUS.GetPermissionById(permissionId);
            if (permission != null)
            {
                txtPermissionId.Text = permission.PermissionId;
                txtPermissionName.Text = permission.PermissionName;
            }

            // Nếu chỉ xem → disable chỉnh sửa
            if (mode == "View")
            {
                txtPermissionName.ReadOnly = true;
                foreach (Control c in tPermission.Controls)
                {
                    if (c is CheckBox cb)
                        cb.Enabled = false;
                }
            }
        }

        private void StyleCheckBoxes(Control parent)
        {
            foreach (Control c in parent.Controls)
            {
                if (c is CheckBox cb)
                {
                    cb.Appearance = Appearance.Button;
                    cb.AutoSize = false;
                    cb.TextAlign = ContentAlignment.MiddleCenter;
                    cb.FlatStyle = FlatStyle.Flat;
                    cb.FlatAppearance.BorderSize = 1;
                    cb.FlatAppearance.BorderColor = Color.Gray;
                    cb.BackColor = Color.WhiteSmoke;
                    cb.Size = new Size(40, 40);

                    cb.CheckedChanged += (s, e) =>
                    {
                        var box = (CheckBox)s;
                        box.BackColor = box.Checked ? ColorTranslator.FromHtml("#007867") : Color.WhiteSmoke;
                        box.ForeColor = box.Checked ? Color.White : Color.Black;
                    };
                }
                else
                {
                    // nếu là container (Panel, GroupBox, TableLayoutPanel...) → duyệt đệ quy
                    StyleCheckBoxes(c);
                }
            }
        }

        private void SetupCheckboxLogic()
        {
            // Duyệt tất cả checkbox trong tPermission
            foreach (Control c in tPermission.Controls)
            {
                if (c is CheckBox cb && cb.Tag != null)
                {
                    cb.CheckedChanged += (s, e) =>
                    {
                        string tag = cb.Tag.ToString();

                        // --- Lấy prefix và target ---
                        string prefix = "";
                        string target = "";
                        if (tag.StartsWith("View")) { prefix = "View"; target = tag.Substring(4); }
                        else if (tag.StartsWith("Insert")) { prefix = "Insert"; target = tag.Substring(6); }
                        else if (tag.StartsWith("Update")) { prefix = "Update"; target = tag.Substring(6); }
                        else if (tag.StartsWith("Delete")) { prefix = "Delete"; target = tag.Substring(6); }

                        // --- Nếu tick Insert/Update/Delete thì phải tick View ---
                        if ((prefix == "Insert" || prefix == "Update" || prefix == "Delete") && cb.Checked)
                        {
                            foreach (Control c2 in tPermission.Controls)
                            {
                                if (c2 is CheckBox cb2 && cb2.Tag != null && cb2.Tag.ToString() == "View" + target)
                                {
                                    cb2.Checked = true;
                                }
                            }
                        }

                        // --- Nếu bỏ tick View thì bỏ luôn Insert & Update & Delete ---
                        if (prefix == "View" && !cb.Checked)
                        {
                            foreach (Control c2 in tPermission.Controls)
                            {
                                if (c2 is CheckBox cb2 && cb2.Tag != null)
                                {
                                    string tag2 = cb2.Tag.ToString();
                                    if (tag2 == "Insert" + target || tag2 == "Update" + target || tag2 == "Delete" + target)
                                    {
                                        cb2.Checked = false;
                                    }
                                }
                            }
                        }
                    };
                }
            }
        }


        private void draftPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void SetupPermissionTable()
        {
            // Bật DoubleBuffered để tránh flicker khi vẽ viền
            typeof(TableLayoutPanel).InvokeMember("DoubleBuffered",
                System.Reflection.BindingFlags.SetProperty | System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic,
                null, tPermission, new object[] { true });

            // Vẽ viền
            tPermission.CellPaint += (s, e) =>
            {
                var g = e.Graphics;
                Rectangle rect = e.CellBounds;

                // --- Tô nền cho header và cột đầu ---
                Color headerColor = ColorTranslator.FromHtml("#007867");
                if (e.Row == 0 || e.Column == 0)
                {
                    using (var b = new SolidBrush(headerColor))
                        g.FillRectangle(b, rect);
                }

                // --- Vẽ viền đầy đủ ---
                using (var p = new Pen(Color.Gray, 1))
                {
                    // Viền phải và dưới (luôn có)
                    g.DrawLine(p, rect.Right - 1, rect.Top, rect.Right - 1, rect.Bottom); // phải
                    g.DrawLine(p, rect.Left, rect.Bottom - 1, rect.Right, rect.Bottom - 1); // dưới

                    // Viền trái cho cột đầu
                    if (e.Column == 0)
                        g.DrawLine(p, rect.Left, rect.Top, rect.Left, rect.Bottom);

                    // Viền trên cho hàng đầu
                    if (e.Row == 0)
                        g.DrawLine(p, rect.Left, rect.Top, rect.Right, rect.Top);
                }
            };


            // Đặt màu chữ trắng cho header và cột đầu
            foreach (Control c in tPermission.Controls)
            {
                var pos = tPermission.GetPositionFromControl(c);
                if (pos.Row == 0 || pos.Column == 0)
                {
                    c.ForeColor = Color.White;
                    c.BackColor = ColorTranslator.FromHtml("#007867");
                    if (c is Label lbl)
                    {
                        lbl.TextAlign = ContentAlignment.MiddleCenter;
                        lbl.Font = new Font(lbl.Font, FontStyle.Bold);
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (txtPermissionName.Text.Trim() == "")
            {
                MessageBox.Show("Tên quyền không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string permissionName = txtPermissionName.Text.Trim();
            List<string> selectedOptions = new List<string>();
            List<PermissionDetailDTO> permissionDetailList = new List<PermissionDetailDTO>();
            foreach (Control c in tPermission.Controls)
            {
                if (c is CheckBox cb && cb.Checked)
                {
                    selectedOptions.Add(cb.Tag.ToString());
                }
            }
            if (selectedOptions.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một chức năng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Ánh xạ đối tượng sang mã chức năng
            Dictionary<string, string> functionMap = new Dictionary<string, string>()
            {
                { "Booking", "F01" },
                { "Court", "F02" },
                { "Sell", "F03" },
                { "Bill", "F04" },
                { "Import", "F05" },
                { "Product", "F06" },
                { "Supplier", "F07" },
                { "Customer", "F08" },
                { "Employee", "F09" },
                { "Account", "F10" },
                { "Permission", "F11" },
                { "Statistic", "F12" }
            };
            foreach (var option in selectedOptions)
            {
                string action = "";
                string target = "";

                // ✅ Cắt phần đầu dựa vào prefix
                if (option.StartsWith("View")) { action = "View"; target = option.Substring(4); }
                else if (option.StartsWith("Insert")) { action = "Insert"; target = option.Substring(6); }
                else if (option.StartsWith("Update")) { action = "Update"; target = option.Substring(6); }
                else if (option.StartsWith("Delete")) { action = "Delete"; target = option.Substring(6); }

                if (functionMap.ContainsKey(target))
                {
                    string functionID = functionMap[target];

                    // Thêm vào danh sách DTO
                    permissionDetailList.Add(new PermissionDetailDTO
                    {
                        PermissionId = permissionId, // Chưa có ID quyền, sẽ gán sau khi tạo quyền
                        FunctionId = functionID,
                        Option = action
                    });
                }
            }
            if (mode == "Insert")
            {
                if (permissionBUS.InsertPermission(new PermissionDTO
                {
                    PermissionId = permissionId,
                    PermissionName = permissionName
                })
                    && permissionDetailBUS.InsertPermissionDetail(permissionDetailList))
                {
                    // Lấy ID quyền vừa tạo
                    string newPermissionId = txtPermissionId.Text;
                    MessageBox.Show("Thêm phân quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Đóng form
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    return;
                }
            }
            else if (mode == "Update")
            {
                if (permissionBUS.UpdatePermission(new PermissionDTO
                {
                    PermissionId = permissionId,
                    PermissionName = permissionName
                })
                    && permissionDetailBUS.UpdatePermissionDetail(permissionDetailList))
                {
                    MessageBox.Show("Cập nhật phân quyền thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Session.TriggerPermissionChange();
                    // Đóng form
                    Form parentForm = this.FindForm();
                    if (parentForm != null)
                    {
                        parentForm.Close();
                    }
                }
                else
                {
                    return;
                }

            }
        }
    }


}
