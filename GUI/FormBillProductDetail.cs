using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class FormBillProductDetail : Form
    {
        private readonly string _billId;
        private readonly BillProductBUS _billBus = new BillProductBUS();
        private readonly BillProductDetailBUS _detailBus = new BillProductDetailBUS();
        private readonly ProductBUS _productBus = new ProductBUS(); // Tái sử dụng
        private readonly AccountDTO? _account;

        public FormBillProductDetail(string billProductId, AccountDTO? account = null)
        {
            _billId = billProductId;
            _account = account;
            InitializeComponent();
        }

        private void FormBillProductDetail_Load(object sender, EventArgs e)
        {
            LoadBillDetail();

            // Hiệu ứng hover cho nút Đóng
            btnClose.MouseEnter += (s, args) => btnClose.BackColor = Color.FromArgb(200, 70, 70);
            btnClose.MouseLeave += (s, args) => btnClose.BackColor = Color.FromArgb(180, 60, 60);
        }

        private void LoadBillDetail()
        {
            try
            {
                var bill = _billBus.GetProductBillById(_billId);
                if (bill == null)
                {
                    MessageBox.Show("Không tìm thấy hóa đơn này!", "Thông báo", 
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                    return;
                }

                var details = _detailBus.GetDetailByBillProductId(_billId);

                // Thông tin hóa đơn
                lblBillId.Text = $"Mã hóa đơn:\n{bill.BillProductId}";
                lblEmployee.Text = $"Nhân viên:\n{(string.IsNullOrWhiteSpace(bill.EmployeeId) ? "Không xác định" : bill.EmployeeId)}";
                lblDate.Text = $"Ngày lập:\n{bill.DateCreated:dd/MM/yyyy HH:mm:ss}";

                // Danh sách sản phẩm
                dgvDetails.Rows.Clear();
                int stt = 1;

                foreach (var item in details)
                {
                    var product = _productBus.GetProductById(item.ProductId);
                    string productName = product?.ProductName ?? "Sản phẩm đã xóa";

                    dgvDetails.Rows.Add(
                        stt++,
                        productName,
                        item.Quantity,
                        item.Price.ToString("N0"),
                        item.TotalPrice.ToString("N0")
                    );
                }

                // Tổng tiền từ chi tiết
                double total = details?.Sum(d => d.TotalPrice) ?? 0.0;
                lblTotalPrice.Text = $"TỔNG TIỀN:\n{total:N0} ₫";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu:\n" + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
private void print_Click(object sender, EventArgs e)
{
    // Lấy mã hóa đơn bán hàng
    string billId = _billId; // đã có sẵn từ constructor

    // Hiển thị dialog lưu file PDF
    SaveFileDialog saveFileDialog = new SaveFileDialog();
    saveFileDialog.Filter = "PDF Files|*.pdf";
    saveFileDialog.FileName = $"HoaDonBanHang_{billId}.pdf";
    saveFileDialog.Title = "Chọn nơi lưu file PDF hóa đơn";

    if (saveFileDialog.ShowDialog() != DialogResult.OK)
    {
        MessageBox.Show("Vui lòng chọn đường dẫn để xuất file!", "Thông báo", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
    }

    string path = saveFileDialog.FileName;

    // Kiểm tra file đã tồn tại
    if (File.Exists(path))
    {
        if (MessageBox.Show("File đã tồn tại. Bạn có muốn ghi đè không?", "Xác nhận", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
        {
            return;
        }
    }

    // Gọi BUS để xuất PDF (tạo phương thức này nếu chưa có)
    BillProductBUS billProductBUS = new BillProductBUS();
    bool result = billProductBUS.ExportBillPdf(billId, path);

    if (!result)
    {
        MessageBox.Show("Xuất file PDF thất bại!", "Lỗi", 
            MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
    else
    {
        MessageBox.Show("Xuất file PDF thành công!", "Thành công", 
            MessageBoxButtons.OK, MessageBoxIcon.Information);

        // Hỏi có muốn mở file không
        if (MessageBox.Show("Bạn có muốn mở file PDF vừa xuất không?", "Mở file", 
            MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = path,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở file:\n" + ex.Message, "Lỗi", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

// Hàm hỗ trợ lấy định dạng ảnh từ đuôi file
private System.Drawing.Imaging.ImageFormat GetImageFormat(string fileName)
{
    string extension = System.IO.Path.GetExtension(fileName).ToLower();
    return extension switch
    {
        ".png" => System.Drawing.Imaging.ImageFormat.Png,
        ".jpg" or ".jpeg" => System.Drawing.Imaging.ImageFormat.Jpeg,
        _ => System.Drawing.Imaging.ImageFormat.Png
    };
}
    }
}