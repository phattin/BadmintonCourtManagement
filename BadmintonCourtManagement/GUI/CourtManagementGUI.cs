using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class CourtManagementGUI : UserControl
    {
        private AccountDTO currentAccount;
        public CourtManagementGUI()
        {
            InitializeComponent();
        }

        public CourtManagementGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void CourtManagementGUI_Load(object sender, EventArgs e)
        {

        }

        private void drPanelCourtMN_Paint(object sender, PaintEventArgs e)
        {   

        }

        private void btncourtDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn xóa sân này không?",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (result == DialogResult.Yes)
            {
                // Thực hiện xóa sân
                MessageBox.Show("Xóa sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
