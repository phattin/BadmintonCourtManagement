using BadmintonCourtManagement.BUS;
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
    public partial class storageGUI : UserControl
    {
        private List<StorageDTO> storageList = new List<StorageDTO>();
        private int index = 1;
        private int itemPerPage = 8;

        public storageGUI(AccountDTO currentAccount)
        {
            InitializeComponent();
            this.Load += StorageGUI_Load;
        }

        // hàm khởi tạo danh sách kho
        private void StorageGUI_Load(object sender, EventArgs e)
        {
            // lấy danh sách kho hàng
            storageList = StorageBUS.GetAllStorages();

            // lấy 8 item đầu tiên
            if (storageList.Count > 0)
            {
                cardList.Controls.Clear();
                int item = 0;
                foreach (var storage in storageList)
                {
                    if (item >= 8) break;
                    else item++;
                    Panel card = new Panel();
                    Button cardButton = new Button();
                    Label cardBody = new Label();
                    Label cardTitle = new Label();

                    card.AutoSize = true;
                    card.BackColor = Color.FromArgb(200, 250, 214);
                    card.Controls.Add(cardButton);
                    card.Controls.Add(cardBody);
                    card.Controls.Add(cardTitle);
                    card.Dock = DockStyle.Fill;
                    card.Location = new Point(15, 15);
                    card.Margin = new Padding(15);
                    card.Name = "card";
                    card.Size = new Size(380, 470);
                    card.TabIndex = 0;

                    cardButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    cardButton.BackColor = Color.Black;
                    cardButton.Cursor = Cursors.Hand;
                    cardButton.Font = new Font("Roboto Condensed", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
                    cardButton.ForeColor = Color.White;
                    cardButton.Location = new Point(57, 347);
                    cardButton.Margin = new Padding(0);
                    cardButton.Name = "cardButton";
                    cardButton.Size = new Size(258, 70);
                    cardButton.TabIndex = 6;
                    cardButton.Text = "Xem chi tiết";
                    cardButton.UseVisualStyleBackColor = false;
                    cardButton.Click += cardButton_Click_1;

                    cardBody.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    cardBody.Font = new Font("Roboto Medium", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    cardBody.Location = new Point(3, 111);
                    cardBody.Name = "cardBody";
                    cardBody.Size = new Size(374, 220);
                    cardBody.TabIndex = 4;
                    cardBody.Text = "Mã sản phẩm: " + storage.ProductId 
                        + "\r\nSố lượng: " + storage.Quantity 
                        + "\r\nGiá: " + storage.Price + "đ";
                    cardBody.TextAlign = ContentAlignment.MiddleCenter;
                    cardBody.Click += cardBody_Click_1;

                    cardTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
                    cardTitle.Font = new Font("Roboto", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    cardTitle.Location = new Point(3, 2);
                    cardTitle.Margin = new Padding(0);
                    cardTitle.Name = "cardTitle";
                    cardTitle.Size = new Size(374, 109);
                    cardTitle.TabIndex = 3;
                    cardTitle.Text = storage.StorageId;
                    cardTitle.TextAlign = ContentAlignment.MiddleCenter;

                    cardList.Controls.Add(card);
                }
            }
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
            filterButton.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void filterButton_MouseLeave(object sender, EventArgs e)
        {
            filterButton.BackColor = Color.FromArgb(0, 120, 103);
        }

        private void cardButton_Click(object sender, EventArgs e)
        {
            StorageDetailsGUI storeDetail = new StorageDetailsGUI();
            storeDetail.ShowDialog();
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
            StorageDetailsGUI storageDetails = new StorageDetailsGUI();
            storageDetails.ShowDialog();
        }

        private void NhapHangButtonCard_Click_1(object sender, EventArgs e)
        {
            SupplyDetailsGUI supplyDetails = new SupplyDetailsGUI();
            supplyDetails.ShowDialog();
        }

        private void filterButton_Click(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SupplyAddGUI supplyAdd = new SupplyAddGUI();
            supplyAdd.ShowDialog();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            SupplyAddGUI supplyAdd = new SupplyAddGUI();
            supplyAdd.ShowDialog();
        }

        private void cardBody_Click_1(object sender, EventArgs e)
        {

        }
    }
}
