﻿using System;
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
    public partial class SupplyAddGUI : Form
    {
        public SupplyAddGUI()
        {
            InitializeComponent();
        }

        private void SupplyAddGUI_Load(object sender, EventArgs e)
        {

        }

        private void supplyProductList1_Load(object sender, EventArgs e)
        {

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
