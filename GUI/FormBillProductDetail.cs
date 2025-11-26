using System;
using System.Drawing;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormBillProductDetail : Form
    {
        private string billId;
        private AccountDTO currentAccount;
        private BillProductBUS billBUS = new BillProductBUS();
        private BillProductDetailBUS detailBUS = new BillProductDetailBUS();

        public FormBillProductDetail(string billProductId, AccountDTO account)
        {
            this.billId = billProductId;
            this.currentAccount = account;
            InitializeComponent();
            LoadBillDetail();
        }

        private void LoadBillDetail()
        {
            try
            {
                var bill = billBUS.GetProductBillById(billId);
                var details = detailBUS.GetDetailByBillProductId(billId);

                lblBillId.Text = bill.BillProductId;
                lblEmployee.Text = bill.EmployeeId;
                lblDate.Text = bill.DateCreated.ToString("dd/MM/yyyy HH:mm:ss");
                lblTotalPrice.Text = bill.TotalPrice.ToString("N0") + " ₫";

                int stt = 1;
                foreach (var item in details)
                {
                    var product = new ProductBUS().GetProductById(item.ProductId);
                    string productName = product?.ProductName ?? "Sản phẩm đã xóa";

                    dgvDetails.Rows.Add(stt++, productName, item.Quantity, item.Price.ToString("N0"), item.TotalPrice.ToString("N0"));
                }

                // Tính lại tổng (phòng khi dữ liệu bị sai lệch)
                double sum = 0;
                foreach (DataGridViewRow row in dgvDetails.Rows)
                {
                    if (row.Cells[4].Value != null)
                        sum += Convert.ToDouble(row.Cells[4].Value.ToString().Replace(",", ""));
                }
                lblTotalPrice.Text = sum.ToString("N0") + " ₫";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải chi tiết hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // private void btnPrint_Click(object sender, EventArgs e)
        // {
        //     // Tạo form in (có thể in trực tiếp hoặc lưu PDF)
        //     PrintBillForm printForm = new PrintBillForm(billId, currentAccount);
        //     printForm.ShowDialog();
        // }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}