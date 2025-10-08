using System;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class InsertPermissionGUI : UserControl
    {
        private PermissionBUS permissionBUS = new PermissionBUS();
        private PermissionDetailBUS permissionDetailBUS = new PermissionDetailBUS();
        public InsertPermissionGUI()
        {
            InitializeComponent();
            SetupPermissionTable();
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
                        box.BackColor = box.Checked ? Color.MediumSeaGreen : Color.WhiteSmoke;
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

        private void draftPanel_Paint(object sender, PaintEventArgs e)
        {
            StyleCheckBoxes(this);
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
            if(txtPermissionName.Text.Trim() == "")
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
                        PermissionId = "", // Chưa có ID quyền, sẽ gán sau khi tạo quyền
                        FunctionId = functionID,
                        PermissionOption = action
                    });
                }
            }

        }
    }


}
