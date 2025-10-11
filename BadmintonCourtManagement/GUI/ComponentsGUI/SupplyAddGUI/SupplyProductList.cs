using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI.ComponentsGUI.SupplyAddGUI
{
    public partial class SupplyProductList : UserControl
    {
        public SupplyProductList()
        {
            InitializeComponent();
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {

        }

        private void FilterButton_MouseEnter(object sender, EventArgs e)
        {
            FilterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void FilterButton_MouseLeave(object sender, EventArgs e)
        {
            FilterButton.BackColor = Color.FromArgb(0, 120, 103);
        }
    }
}
