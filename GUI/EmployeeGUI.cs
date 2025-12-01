using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using GUI;
using Mysqlx.Crud;
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
    public partial class EmployeeGUI : UserControl
    {
        private AccountDTO currentAccount;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;
        public EmployeeGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            CheckPermissions("F09");
        }

        private void CheckPermissions(string functionId)
        {
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId(functionId);

            foreach (var p in permissionDetails)
            {
                if (p.PermissionId == currentAccount.PermissionId)
                {
                    if (p.Option == "Insert") isInsert = true;
                    else if (p.Option == "Update") isUpdate = true;
                    else if (p.Option == "Delete") isDelete = true;
                }
            }

            add.Visible = isInsert;
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

        private void storageGUI_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {


        }

        private void filterButton_MouseEnter(object sender, EventArgs e)
        {
            filter.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {
            filter.BackColor = Color.FromArgb(0, 120, 103);
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            EmployeeDetailsGUI employeeDetail = new EmployeeDetailsGUI();
            employeeDetail.ShowDialog();
        }

        private void cardTitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhapHangFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangButtonCard_Click(object sender, EventArgs e)
        {
            SupplyDetailsGUI supplyDetails = new SupplyDetailsGUI();
            supplyDetails.ShowDialog();
        }

        private void NhapHangBodyCard_Click(object sender, EventArgs e)
        {

        }

        private void cardBody_Click(object sender, EventArgs e)
        {

        }

        private void cardButton_Click_1(object sender, EventArgs e)
        {
            EmployeeDetailsGUI employeeDetails = new EmployeeDetailsGUI();
            employeeDetails.ShowDialog();
        }

        private void add_Click(object sender, EventArgs e)
        {
            EmployeeAddGUI employeeAdd = new EmployeeAddGUI();
            employeeAdd.ShowDialog();
        }
    }
}
