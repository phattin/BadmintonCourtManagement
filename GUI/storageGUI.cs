using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using GUI.ComponentsGUI;
using GUI.Utils;
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
        private AccountDTO currentAccount;

        // Import bill page fields
        private List<ImportBillDTO> supplyList = new List<ImportBillDTO>();
        private List<ImportBillDTO> supplyOldList = new List<ImportBillDTO>();
        private List<ImportBillDTO> supplySearchList = new List<ImportBillDTO>();
        private int supplyPage = 0;
        private int supplyItemPerPage = 8;
        private Boolean supplyIsFiltered = false;

        public storageGUI(AccountDTO currentAccount, List<StorageDTO> storageList, List<ImportBillDTO> importBillList)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();
            this.storageList = storageList;
            this.supplyList = importBillList;
            this.Load += StorageGUI_Load;
        }

        // hàm khởi tạo danh sách kho
        private void StorageGUI_Load(object sender, EventArgs e)
        {
            // lấy danh sách kho hàng
            //storageList = StorageBUS.GetAllStorages();
            oldList = storageList;
            searchList = oldList;
            page = 0;
            Pagination();

            // Load import bills for supply page
            LoadSupplyList();
        }

        // Load import bill list
        private void LoadSupplyList()
        {
            // supplyList = new BillImportBUS().GetAllImportBills();
            supplyOldList = supplyList;
            supplySearchList = supplyOldList;
            supplyPage = 0;
            SupplyPagination();
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
                            CustomPanel card = new CustomPanel();
                            RoundedButton cardButton = new RoundedButton();
                            Label cardBody = new Label();
                            Label cardTitle = new Label();

                            card.AutoSize = false;
                            card.BorderRadius = 20;
                            card.AutoScroll = true;
                            card.BackColor = Color.FromArgb(200, 250, 214);
                            card.Controls.Add(cardButton);
                            card.Controls.Add(cardBody);
                            card.Controls.Add(cardTitle);
                            card.Dock = DockStyle.Fill;
                            card.Padding = new Padding(20, 10, 20, 10);
                            card.Name = "card";
                            card.TabIndex = 0;

                            cardButton.Dock = DockStyle.Top;
                            cardButton.BackgroundColor = Color.Black;
                            cardButton.Cursor = Cursors.Hand;
                            cardButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardButton.TextColor = Color.White;
                            cardButton.Name = "cardButton";
                            cardButton.Size = new Size(258, 60);
                            // cardButton.TabIndex = 6;
                            cardButton.Text = "Xem chi tiết";
                            cardButton.UseVisualStyleBackColor = false;
                            cardButton.MouseEnter += buttonEnter;
                            cardButton.MouseLeave += buttonLeave;
                            cardButton.Click += cardButton_Click;

                            Additional additional = new Additional();
                            cardBody.Dock = DockStyle.Top;
                            cardBody.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardBody.Name = "cardBody";
                            cardBody.Size = new Size(374, 180);
                            cardBody.TabIndex = 4;
                            cardBody.Text = "Mã sản phẩm: " + storageList[i].ProductId
                                + "\r\nSố lượng: " + storageList[i].Quantity
                                + "\r\nGiá: " + additional.beautyMoney(storageList[i].Price)
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
                        || item.ImportBillDetailId.Contains(info, StringComparison.OrdinalIgnoreCase)
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
            StorageGUI_Load(sender, e);
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

        // ==================== SUPPLY PAGE (NHẬP HÀNG) METHODS ====================

        // Hàm phân trang cho nhập hàng
        private void SupplyPagination()
        {
            try
            {
                if (supplyList.Count > 0)
                {
                    supplyCardList.Controls.Clear();
                    int index = supplyPage * supplyItemPerPage;
                    for (int i = index; i < index + supplyItemPerPage; i++)
                    {
                        if (i <= supplyList.Count() - 1 && i >= 0)
                        {
                            CustomPanel card = new CustomPanel();
                            RoundedButton cardButton = new RoundedButton();
                            Label cardBody = new Label();
                            Label cardTitle = new Label();

                            card.AutoSize = false;
                            card.BorderRadius = 20;
                            card.AutoScroll = true;
                            card.BackColor = Color.FromArgb(200, 250, 214);
                            card.Controls.Add(cardButton);
                            card.Controls.Add(cardBody);
                            card.Controls.Add(cardTitle);
                            card.Dock = DockStyle.Fill;
                            card.Padding = new Padding(20, 10, 20, 10);
                            card.Name = "card";
                            card.TabIndex = 0;

                            cardButton.Dock = DockStyle.Top;
                            cardButton.BackgroundColor = Color.Black;
                            cardButton.Cursor = Cursors.Hand;
                            cardButton.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardButton.TextColor = Color.White;
                            cardButton.Name = "cardButton";
                            cardButton.Size = new Size(258, 60);
                            cardButton.Text = "Chi tiết";
                            cardButton.UseVisualStyleBackColor = false;
                            // cardButton.BackColor = Color.Black;
                            // cardButton.ForeColor = Color.White;
                            // cardButton.BorderRadius = 20;
                            // cardButton.TabIndex = 2;
                            cardButton.MouseEnter += buttonEnter;
                            cardButton.MouseLeave += buttonLeave;
                            cardButton.Click += supplyCardButton_Click;

                            Additional additional = new Additional();
                            var status = supplyList[i].Status.ToString();
                            cardBody.Dock = DockStyle.Top;
                            cardBody.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
                            cardBody.Name = "cardBody";
                            cardBody.Size = new Size(374, 180);
                            cardBody.Text =
                                "Mã nhân viên: " + supplyList[i].EmployeeId + "\r\n" +
                                "Mã nhà cung cấp: " + supplyList[i].SupplierId + "\r\n" +
                                "Ngày tạo: " + supplyList[i].DateCreated.ToString("dd/MM/yyyy") + "\r\n" +
                                "Tổng tiền: " + supplyList[i].TotalPrice.ToString("N0") + " VND\r\n" +
                                "Trạng thái: " + (status == "delivered" ? "Đã giao" : status == "pending" ? "Chờ xử lý" : status == "cancelled" ? "Đã hủy" : status == "paid" ? "Đã thanh toán" : "Chưa thanh toán");
                            // cardBody.AutoSize = false;
                            // cardBody.Padding = new Padding(0, 10, 0, 0);
                            // cardBody.TabIndex = 1;

                            // cardTitle.AutoSize = false;
                            cardTitle.Dock = DockStyle.Top;
                            cardTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
                            cardTitle.Name = "cardTitle";
                            cardTitle.Size = new Size(374, 80);
                            // cardTitle.TabIndex = 0;
                            cardTitle.Text = supplyList[i].ImportBillId;
                            cardTitle.TextAlign = ContentAlignment.MiddleCenter;

                            supplyCardList.Controls.Add(card);
                        }
                        else break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi phân trang: " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Sự kiện chuyển trang nhập hàng
        private void supplyPrevious_Click(object sender, EventArgs e)
        {
            supplyPage--;
            if (supplyPage < 0) supplyPage = 0;
            SupplyPagination();
        }

        private void supplyNext_Click(object sender, EventArgs e)
        {
            supplyPage++;
            if (supplyPage > (int)Math.Ceiling((double)supplyList.Count() / supplyItemPerPage) - 1)
                supplyPage = (int)Math.Ceiling((double)supplyList.Count() / supplyItemPerPage) - 1;
            SupplyPagination();
        }

        private void supplyExtraPrevious_Click(object sender, EventArgs e)
        {
            supplyPage = 0;
            SupplyPagination();
        }

        private void supplyExtraNext_Click(object sender, EventArgs e)
        {
            supplyPage = (int)Math.Ceiling((double)supplyList.Count() / supplyItemPerPage) - 1;
            if (supplyPage < 0) supplyPage = 0;
            SupplyPagination();
        }

        // Hàm tìm kiếm nhập hàng
        private void supplySearchEnterEvent(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SupplySearch(supplySearchBar.Text);
            }
        }

        private void SupplySearch(string info)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(info))
                {
                    supplySearchList = new List<ImportBillDTO>();
                    foreach (var item in supplyOldList)
                    {
                        if (item.ImportBillId.ToLower().Contains(info.ToLower()) ||
                            item.EmployeeId.ToLower().Contains(info.ToLower()) ||
                            item.SupplierId.ToLower().Contains(info.ToLower()) ||
                            item.Status.ToString().ToLower().Contains(info.ToLower()))
                        {
                            supplySearchList.Add(item);
                        }
                    }

                    if (supplyIsFiltered)
                    {
                        List<ImportBillDTO> temp = new List<ImportBillDTO>();
                        foreach (var item in supplyList)
                        {
                            if (supplySearchList.Contains(item))
                            {
                                temp.Add(item);
                            }
                        }
                        supplySearchList = temp;
                    }

                    if (supplySearchList.Count > 0)
                    {
                        supplyList = supplySearchList;
                        supplyPage = 0;
                        SupplyPagination();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy kết quả",
                            "Thông báo",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else
                {
                    if (supplyIsFiltered)
                    {
                        supplySearchList = supplyList;
                    }
                    else
                    {
                        supplyList = supplyOldList;
                        supplySearchList = supplyOldList;
                    }
                    supplyPage = 0;
                    SupplyPagination();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm: " + ex.Message,
                    "Cảnh báo",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        // Hàm reset nhập hàng
        private void supplyReset_Click(object sender, EventArgs e)
        {
            supplyList = supplyOldList;
            supplySearchList = supplyOldList;
            supplyIsFiltered = false;
            supplyPage = 0;
            supplySearchBar.Clear();
            SupplyPagination();
            StorageGUI_Load(sender, e);
        }

        // Hàm lọc theo ngày nhập hàng
        private void supplyFilter_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime start = supplyStartDate.Value.Date;
                DateTime end = supplyEndDate.Value.Date;

                if (start > end)
                {
                    MessageBox.Show("Ngày bắt đầu không thể lớn hơn ngày kết thúc",
                        "Cảnh báo",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                List<ImportBillDTO> temp = new List<ImportBillDTO>();
                foreach (var item in supplyOldList)
                {
                    if (item.DateCreated.Date >= start && item.DateCreated.Date <= end)
                    {
                        temp.Add(item);
                    }
                }

                if (!string.IsNullOrWhiteSpace(supplySearchBar.Text))
                {
                    List<ImportBillDTO> temp2 = new List<ImportBillDTO>();
                    foreach (var item in temp)
                    {
                        if (supplySearchList.Contains(item))
                        {
                            temp2.Add(item);
                        }
                    }
                    temp = temp2;
                }

                if (temp.Count > 0)
                {
                    supplyList = temp;
                    supplyIsFiltered = true;
                    supplyPage = 0;
                    SupplyPagination();
                }
                else
                {
                    supplyIsFiltered = false;
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

        // Xem chi tiết đơn nhập hàng
        private void supplyCardButton_Click(object sender, EventArgs e)
        {
            Button cardButton = sender as Button;
            if (cardButton == null) return;
            Panel card = cardButton.Parent as Panel;
            if (card == null) return;
            Label cardTitle = card.Controls["cardTitle"] as Label;
            if (cardTitle == null) return;

            foreach (var item in supplySearchList)
            {
                if (item.ImportBillId.Equals(cardTitle.Text.ToString()))
                {
                    // Get import bill details
                    BillImportDetailBUS importDetail = new BillImportDetailBUS();
                    List<BillImportDetailDTO> details = importDetail.GetDetailImportBillsByImportBillId(item.ImportBillId);

                    // Open SupplyDetailsGUI with details
                    SupplyDetailsGUI supplyDetails = new SupplyDetailsGUI(details);
                    supplyDetails.ShowDialog();

                    // Refresh list after closing details
                    LoadSupplyList();
                    return;
                }
            }
        }

        // Thêm đơn nhập hàng mới
        private void supplyAdd_Click(object sender, EventArgs e)
        {
            SupplyAddGUI supplyAdd = new SupplyAddGUI(currentAccount);
            supplyAdd.ShowDialog();
            if (supplyAdd.ResultBill != null)
            {
                // Avoid duplicates: remove any existing with same id then add
                supplyList.RemoveAll(b => b.ImportBillId == supplyAdd.ResultBill.ImportBillId);
                supplyList.Add(supplyAdd.ResultBill);
            }
            // Refresh list after closing add form
            LoadSupplyList();
        }

        private void supplyFilter_MouseEnter(object sender, EventArgs e)
        {
            supplyFilter.BackColor = Color.FromArgb(0, 142, 123);
        }

        private void supplyFilter_MouseLeave(object sender, EventArgs e)
        {
            supplyFilter.BackColor = Color.FromArgb(0, 120, 103);
        }

        // ==================== END SUPPLY PAGE METHODS ====================

        private void cardTitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void NhapHangFilterButton_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangButtonCard_Click(object sender, EventArgs e)
        {
            // Deprecated - use supplyCardButton_Click instead
        }

        private void NhapHangBodyCard_Click(object sender, EventArgs e)
        {

        }

        private void cardBody_Click(object sender, EventArgs e)
        {

        }

        private void NhapHangButtonCard_Click_1(object sender, EventArgs e)
        {
            // Deprecated - use supplyCardButton_Click instead
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            SupplyAddGUI supplyAdd = new SupplyAddGUI(currentAccount);
            supplyAdd.ShowDialog();
        }

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            SupplyAddGUI supplyAdd = new SupplyAddGUI(currentAccount);
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
