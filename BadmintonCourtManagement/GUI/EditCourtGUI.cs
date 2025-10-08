using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class EditCourtGUI : UserControl
    {
        private CourtDTO currentCourt;
        private CourtBUS courtBUS;

        public EditCourtGUI(CourtDTO court)
        {
            InitializeComponent();
            currentCourt = court;
            courtBUS = new CourtBUS();

            LoadCourtInfo();
        }

        private void LoadCourtInfo()
        {
            // Load trạng thái cố định
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Hoạt động");
            comboBox1.Items.Add("Bảo trì");

            // Hiển thị thông tin sân hiện tại
            textBox1.Text = currentCourt.CourtName;

            // Chọn đúng trạng thái hiện tại
            if (currentCourt.Status.ToString() == "active" || currentCourt.Status.ToString() == "Hoạt động")
                comboBox1.SelectedItem = "Hoạt động";
            else
                comboBox1.SelectedItem = "Bảo trì";
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                // Cập nhật thông tin sân
                currentCourt.CourtName = textBox1.Text.Trim();
                currentCourt.Status = comboBox1.SelectedItem.ToString() == "Hoạt động"
                    ? CourtDTO.Option.active
                    : CourtDTO.Option.maintenance;

                courtBUS.UpdateCourt(currentCourt);

                MessageBox.Show("Cập nhật sân thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Đóng form cha (dialog)
                Form parentForm = this.FindForm();
                if (parentForm != null)
                    parentForm.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sân: " + ex.Message,
                    "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
