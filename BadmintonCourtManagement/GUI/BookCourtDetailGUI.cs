using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public partial class BookCourtDetailGUI : UserControl
    {
        private AccountDTO currentAccount;

        public BookCourtDetailGUI()
        {
            InitializeComponent();
        }

        public BookCourtDetailGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
        }

        private void BookCourtDetail_Load(object sender, EventArgs e)
        {

        }

        private void customPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
