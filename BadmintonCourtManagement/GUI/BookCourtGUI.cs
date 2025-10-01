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
    }
}
