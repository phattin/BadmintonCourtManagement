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

namespace GUI
{
    public partial class PriceRuleDescriptionGUI : Form
    {
        public PriceRuleDescriptionGUI(PriceRuleDTO priceRule)
        {
            InitializeComponent();
            if (priceRule != null)
            {
                if (string.IsNullOrEmpty(priceRule.Description))
                {
                    labelDescription.Text = "(Không có mô tả)";
                }
                else
                {
                    labelDescription.Text = priceRule.Description;
                }

                this.Text = "Chi tiết mô tả - " + priceRule.PriceRuleId;
            }
        }
    }
}
