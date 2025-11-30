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
            Status.Items.Add("Hoạt động");
            Status.Items.Add("Bảo trì");

            if (mode == "Insert")
            {
                Title.Text = "Thêm sân";
                txtCourtName.Text = "";
                Status.SelectedIndex = 0;
            }
            else if (mode == "Update")
            {
                Title.Text = "Sửa sân";

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
            var status = Status.SelectedItem.ToString() == "Hoạt động"
                ? CourtDTO.Option.active
                : CourtDTO.Option.maintenance;

            // ---- THÊM MỚI ----
            if (mode == "Insert")
            {
                if (courtBUS.InsertCourt(new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = courtName,
                    Status = status
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
                if (courtBUS.UpdateCourt(new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = courtName,
                    Status = status
                }))
                {
                    MessageBox.Show("Cập nhật sân thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
