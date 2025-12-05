using BadmintonCourtManagement.BUS;
using GUI.ComponentsGUI;
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
    public partial class SupplyDetailsGUI : Form
    {
        public SupplyDetailsGUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void filterButton_MouseEnter(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
        }

        private void buttonEnter(object sender, EventArgs e)
        {
            RoundedButton btn = sender as RoundedButton;
            if (btn != null)
            {
                btn.BackgroundColor = Color.FromArgb(60, 60, 60);
            }
        }

        private void buttonLeave(object sender, EventArgs e)
        {
            RoundedButton btn = sender as RoundedButton;
            if (btn != null)
            {
                btn.BackgroundColor = Color.Black;
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            // lấy mã nhập hàng
            string supplyId = Title.Text.Split(": ")[2];
            //string supplyId = "IB00003";
            MessageBox.Show(supplyId);

            // lấy path xuất file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF Files|*.pdf";
            saveFileDialog.FileName = $"BillImport_{supplyId}.pdf";

            if (saveFileDialog.ShowDialog() != DialogResult.OK)
            {
                MessageBox.Show("Vui lòng chọn đường dẫn xuất file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } else
            {
                string path = saveFileDialog.FileName;
                if(File.Exists(path))
                {
                    MessageBox.Show("File đã tồn tại! Vui lòng chọn đường dẫn khác.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } else
                {
                    BillImportBUS billImportBUS = new BillImportBUS();
                    bool result = billImportBUS.ExportBill(supplyId, path);
                    if (!result)
                    {
                        MessageBox.Show("Xuất file thất bại!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Xuất file thành công!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }  
        }

        private void Title_Click(object sender, EventArgs e)
        {

        }
    }
}
