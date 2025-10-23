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
        private List<StorageDTO> oldList = new List<StorageDTO>();
        private List<StorageDTO> searchList = new List<StorageDTO>();
        private List<string> filter = new List<string>();
        private int page = 0;
        private int itemPerPage = 8;
        private Boolean isFiltered = false;

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
            oldList = storageList;
            searchList = oldList;
            page = 0;
            Pagination();
        }

        // hàm phân trang
        private void Pagination()
        {
            try
            {
                // lấy item
                if (storageList.Count > 0)
                {
                    cardList.Controls.Clear();
                    int index = page * itemPerPage;
                    for (int i = index; i < index + itemPerPage; i++)
                    {
                        if (i <= storageList.Count() - 1 && i >= 0)
                        {
                            Panel card = new Panel();
                            Button cardButton = new Button();
                            Label cardBody = new Label();
                            Label cardTitle = new Label();

                            card.AutoSize = false;
                            card.AutoScroll = true;
                            card.BackColor = Color.FromArgb(200, 250, 214);
                            card.Controls.Add(cardButton);
                            card.Controls.Add(cardBody);
                            card.Controls.Add(cardTitle);
                            card.Dock = DockStyle.Fill;
                            card.Margin = new Padding(30);
                            card.Name = "card";
                            card.TabIndex = 0;

                            cardButton.Dock = DockStyle.Top;
                            cardButton.BackColor = Color.Black;
                            cardButton.Cursor = Cursors.Hand;
                            cardButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardButton.ForeColor = Color.White;
                            cardButton.Name = "cardButton";
                            cardButton.Size = new Size(258, 60);
                            cardButton.TabIndex = 6;
                            cardButton.Text = "Xem chi tiết";
                            cardButton.UseVisualStyleBackColor = false;
                            cardButton.MouseEnter += buttonEnter;
                            cardButton.MouseLeave += buttonLeave;
                            cardButton.Click += cardButton_Click;

                            cardBody.Dock = DockStyle.Top;
                            cardBody.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardBody.Name = "cardBody";
                            cardBody.Size = new Size(374, 180);
                            cardBody.TabIndex = 4;
                            cardBody.Text = "Mã sản phẩm: " + storageList[i].ProductId
                                + "\r\nSố lượng: " + storageList[i].Quantity
                                + "\r\nGiá: " + storageList[i].Price + "đ"
                                + "\r\nNgày: " + storageList[i].CreatedAt.ToString("dd/MM/yyyy");
                            cardBody.TextAlign = ContentAlignment.MiddleCenter;
                            cardBody.Click += cardBody_Click_1;

                            cardTitle.Dock = DockStyle.Top;
                            cardTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
                            cardTitle.Name = "cardTitle";
                            cardTitle.Size = new Size(374, 80);
                            cardTitle.TabIndex = 3;
                            cardTitle.Text = storageList[i].StorageId;
                            cardTitle.TextAlign = ContentAlignment.MiddleCenter;

                            cardList.Controls.Add(card);
                        }
                        else break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi phân trang " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // sự kiện chuyển trang
        private void previousButton_Click(object sender, EventArgs e)
        {
            page--;
            if (page < 0) page = 0;
            Pagination();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            page++;
            if (page > (int)Math.Ceiling((double)storageList.Count() / 8) - 1)
                page = (int)Math.Ceiling((double)storageList.Count() / 8) - 1;
            Pagination();
        }

        private void extraPreviousButton_Click(object sender, EventArgs e)
        {
            page = 0;
            Pagination();
        }

        private void extraNextButton_Click(object sender, EventArgs e)
        {
            page = (int)Math.Ceiling((double)storageList.Count() / 8) - 1;
            if (page < 0) page = 0;
            Pagination();
        }

        // hàm sự kiện tìm kiếm
        private void searchEnterEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                search(searchBar.Text.ToString());
            }
        }

        // hàm tìm kiếm
        private void search(string info)
        {
            try
            {
                List<StorageDTO> tempList = new List<StorageDTO>();
                List<StorageDTO> replaceList = oldList;

                if (string.IsNullOrWhiteSpace(info))
                {
                    MessageBox.Show("Vui lòng nhập thông tin cần tìm.",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool isInt = int.TryParse(info, out int intValue);
                bool isDouble = double.TryParse(info, out double doubleValue);

                if (isFiltered) replaceList = storageList;

                foreach (var item in replaceList)
                {
                    bool match = false;

                    if (item.StorageId.Contains(info, StringComparison.OrdinalIgnoreCase)
                        || item.ProductId.Contains(info, StringComparison.OrdinalIgnoreCase)
                        || item.ImportBillId.Contains(info, StringComparison.OrdinalIgnoreCase)
                        || item.Status.ToString().Contains(info, StringComparison.OrdinalIgnoreCase))
                    {
                        match = true;
                    }

                    if (isInt && item.Quantity == intValue)
                        match = true;

                    if (isDouble && (item.Price == doubleValue || item.TotalPrice == doubleValue))
                        match = true;

                    if (match)
                        tempList.Add(item);
                }

                if (tempList.Count() > 0)
                {
                    page = 0;
                    storageList = tempList;
                    searchList = storageList;
                    Pagination();
                    searchBar.Text = ""; // reset tìm kiếm
                }
                else
                {
                    MessageBox.Show("Không tìm thấy kết quả phù hợp",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // hàm reset item
        private void Reset_Click(object sender, EventArgs e)
        {
            page = 0;
            storageList = oldList;
            searchList = oldList;
            Pagination();
            isFiltered = false;
            searchBar.Text = "";
        }

        // hàm lọc theo ngày
        private void filterButton_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = startDate.Value;
                DateTime end = endDate.Value;

                List<StorageDTO> tempList = new List<StorageDTO>();
                foreach (var item in searchList)
                {
                    if (item.CreatedAt >= start && item.CreatedAt <= end)
                    {
                        tempList.Add(item);
                    }
                }

                if (tempList.Count > 0)
                {
                    page = 0;
                    storageList = tempList;
                    Pagination();
                    isFiltered = true;
                }
                else
                {
                    isFiltered = false;
                    MessageBox.Show("Không tìm thấy kết quả theo bộ lọc",
                        "Thông báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi lọc " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // hàm xem chi tiết kho hàng
        private void cardButton_Click(object sender, EventArgs e)
        {
            Button cardButton = sender as Button;
            if (cardButton == null) return;
            Panel card = cardButton.Parent as Panel;
            if (card == null) return;
            Label cardTitle = card.Controls["cardTitle"] as Label;
            if (cardTitle == null) return;

            foreach (var item in searchList)
            {
                if (item.StorageId.Equals(cardTitle.Text.ToString()))
                {
                    StorageDetailsGUI storeDetail = new StorageDetailsGUI(item);
                    storeDetail.ShowDialog();
                    return;
                }
            }
        }

        // các hàm tạm
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

        private void NhapHangButtonCard_Click_1(object sender, EventArgs e)
        {
            SupplyDetailsGUI supplyDetails = new SupplyDetailsGUI();
            supplyDetails.ShowDialog();
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

        private void cardList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void titleText_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangToolBar_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
