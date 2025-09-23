using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class MainLayout : Form
    {
        public MainLayout(AccountDTO account)
        {
            AccountDTO accountCurrent = account;
            InitializeComponent();
        }
    }
}
