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
    public partial class SupplyDetails : UserControl
    {
        public SupplyDetails()
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

        private void buttonEnter(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.Black;
            }
        }
    }
}
