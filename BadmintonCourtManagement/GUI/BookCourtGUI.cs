using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System.Runtime.InteropServices;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtGUI : UserControl
    {
        private AccountDTO currentAccount;

        public BookCourtGUI(AccountDTO account)
        {
            // AccountDTO accountCurrent = account;
            currentAccount = account;
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            // xử lý khi đặt sân
        }

        private void pCourt_Paint(object sender, PaintEventArgs e)
        {
            // nếu cần custom vẽ thêm
        }

        private void pFilter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCourt2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pCourt3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lblDate.Text = dateTimePicker1.Value.ToString("dd/MM/yyyy");
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            lbltimeStart.Text = dateTimePicker2.Value.ToString("HH:mm");
        }

        private void btnBooking2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var detailGUI = new BookCourtDetailGUI(currentAccount);
            detailGUI.Dock = DockStyle.Fill;
            this.Controls.Add(detailGUI);
        }

        private void btnEndTime_ValueChanged(object sender, EventArgs e)
        {
            lbltimeFinish.Text = btnEndTime.Value.ToString("HH:mm");
        }
    }
}
