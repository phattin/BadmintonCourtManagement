using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormCourtGUI : UserControl
    {
        private string mode;
        private string courtId;
        private AccountDTO currentAccount;
        private CourtBUS courtBUS = new CourtBUS();

        private List<CourtDTO> courtList;    

        public FormCourtGUI(string mode, string courtId, AccountDTO currentAccount, List<CourtDTO> courtList)
        {
            this.mode = mode;
            this.courtId = courtId;
            this.currentAccount = currentAccount;
            this.courtList = courtList;    

            InitializeComponent();

            CourtID.Text = courtId;

            Status.Items.Clear();

            if (mode == "Insert")
            {
                Title.Text = "Thêm sân";
                txtCourtName.Text = "";

                Status.Items.Add("Hoạt động");
                Status.SelectedIndex = 0;
                Status.Enabled = false;
            }
            else if (mode == "Update")
            {
                Title.Text = "Sửa sân";

                Status.Items.Add("Hoạt động");
                Status.Items.Add("Bảo trì");
                Status.Enabled = true;

                var court = courtList.Find(c => c.CourtId == courtId); // <<< LOAD TỪ LIST, KHÔNG TỪ DB
                if (court != null)
                {
                    txtCourtName.Text = court.CourtName;
                    Status.SelectedItem =
                        court.Status == CourtDTO.Option.active ? "Hoạt động" : "Bảo trì";
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

            string name = txtCourtName.Text.Trim();

            // --------- INSERT ---------
            if (mode == "Insert")
            {
                var newCourt = new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = name,
                    Status = CourtDTO.Option.active
                };

                if (courtBUS.InsertCourt(newCourt))
                {
                    // Cập nhật list ngay lập tức
                    courtList.Add(newCourt);

                    MessageBox.Show("Thêm sân thành công!", "Thành công", MessageBoxButtons.OK);

                    this.FindForm()?.Close();
                }
                return;
            }

            // --------- UPDATE ---------
            if (mode == "Update")
            {
                var status = Status.SelectedItem.ToString() == "Hoạt động"
                    ? CourtDTO.Option.active
                    : CourtDTO.Option.maintenance;

                var updatedCourt = new CourtDTO
                {
                    CourtId = courtId,
                    CourtName = name,
                    Status = status
                };

                if (courtBUS.UpdateCourt(updatedCourt))
                {
                    // UPDATE LIST
                    var index = courtList.FindIndex(c => c.CourtId == courtId);
                    if (index >= 0)
                        courtList[index] = updatedCourt;

                    MessageBox.Show("Cập nhật sân thành công!", "Thành công", MessageBoxButtons.OK);

                    this.FindForm()?.Close();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.FindForm()?.Close();
        }
    }
}
