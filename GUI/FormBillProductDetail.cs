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
    try
    {
        // Đường dẫn tuyệt đối đến thư mục ORDER (cùng cấp với file exe)
        // string orderFolder = Path.Combine(Application.StartupPath, "ORDER");
        string projectRoot = Directory.GetParent(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.Parent.Parent.FullName;
        string orderFolder = Path.Combine(projectRoot, "ORDER");                              

        // Tạo thư mục nếu chưa tồn tại (dù bạn nói đã tạo rồi, nhưng cứ kiểm tra cho chắc)
        if (!Directory.Exists(orderFolder))
            Directory.CreateDirectory(orderFolder);

        // Tên file đẹp, không trùng: HD_BP001_20251129_143022.png
        string fileName = $"HD_{_billId}_{DateTime.Now:yyyyMMdd_HHmmss}.png";
        string fullPath = Path.Combine(orderFolder, fileName);

        // Ẩn tạm 2 nút để ảnh hóa đơn sạch sẽ, đẹp như in thật
        bool printWasVisible = print.Visible;
        bool closeWasVisible = btnClose.Visible;

        print.Visible = false;
        btnClose.Visible = false;
        customPanelMain.Refresh();
        Application.DoEvents();

        // Chụp ảnh toàn bộ panel hóa đơn
        using (Bitmap bitmap = new Bitmap(customPanelMain.Width, customPanelMain.Height))
        {
            customPanelMain.DrawToBitmap(bitmap, new Rectangle(0, 0, bitmap.Width, bitmap.Height));
            bitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);
        }

        // Hiện lại nút
        print.Visible = printWasVisible;
        btnClose.Visible = closeWasVisible;

        // Thông báo + tự động mở thư mục ORDER luôn
        MessageBox.Show(
            $"Đã xuất hóa đơn thành công!\n\n" +
            $"Tên file: {fileName}\n" +
            $"Lưu tại: {orderFolder}\n\n" +
            $"Thư mục ORDER sẽ tự động mở để bạn kiểm tra.",
            "Xuất hóa đơn thành công",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information);

        // Mở thư mục ORDER để nhân viên thấy file vừa xuất
        System.Diagnostics.Process.Start("explorer.exe", orderFolder);
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi khi xuất hóa đơn:\n" + ex.Message, "Lỗi",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
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