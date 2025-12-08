using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormCourtGUI : UserControl
    {
        private string mode; // Insert hoặc Update
        private string courtId;
        private AccountDTO currentAccount;
        private CourtBUS courtBUS = new CourtBUS();

        public FormCourtGUI(string mode, string courtId, AccountDTO currentAccount)
        {
            this.mode = mode;
            this.courtId = courtId;
            this.currentAccount = currentAccount;

            InitializeComponent();

            // Gán sẵn ID sân (label hiển thị, không sửa)
            CourtID.Text = courtId;

            Status.Items.Clear();

            if (mode == "Insert")
            {
                Title.Text = "Thêm sân";
                txtCourtName.Text = "";

                // Chỉ thêm "Hoạt động" cho form Thêm
                Status.Items.Add("Hoạt động");
                Status.SelectedIndex = 0;
                Status.Enabled = false; // Không cho thay đổi
            }
            else if (mode == "Update")
            {
                Title.Text = "Sửa sân";

                // Thêm cả 2 options cho form Sửa
                Status.Items.Add("Hoạt động");
                Status.Items.Add("Bảo trì");
                Status.Enabled = true; // Cho phép thay đổi

                // Load thông tin sân
                var court = courtBUS.GetCourtById(courtId);
                if (court != null)
                {
                    txtCourtName.Text = court.CourtName;
                    Status.SelectedItem = court.Status == CourtDTO.Option.active
                        ? "Hoạt động"
                        : "Bảo trì";
                }
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (txtCourtName.Text.Trim() == "")
            {
                MessageBox.Show("Tên sân không được để trống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string courtName = txtCourtName.Text.Trim();

            // ---- THÊM MỚI ----
            if (mode == "Insert")
            {
                if (courtBUS.InsertCourt(new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = courtName,
                    Status = CourtDTO.Option.active  // Luôn là active
                }))
                {
                    MessageBox.Show("Thêm sân thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // ---- CẬP NHẬT ----
            else if (mode == "Update")
            {
                var status = Status.SelectedItem.ToString() == "Hoạt động"
                    ? CourtDTO.Option.active
                    : CourtDTO.Option.maintenance;

                if (courtBUS.UpdateCourt(new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = courtName,
                    Status = status
                }))
                {
                    MessageBox.Show("Cập nhật sân thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Form parentForm = this.FindForm();
            if (parentForm != null)
                parentForm.Close();
        }

        private void CourtID_Click(object sender, EventArgs e)
        {

        }
    }
}
