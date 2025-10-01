using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtGUI : UserControl
    {
        private AccountDTO currentAccount;
        public BookCourtGUI(AccountDTO account)
        {
            AccountDTO accountCurrent = account;
            InitializeComponent();
        }

        private void btnBooking_Click(object sender, EventArgs e)
        {

        }
    }
}