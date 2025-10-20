using BadmintonCourtManagement.DTO;
using GUI.Utils;

namespace BadmintonCourtManagement.GUI
{
    public partial class StorageDetailsGUI : Form
    {
        public StorageDetailsGUI(StorageDTO storage)
        {
            InitializeComponent();
            try
            {
                Random random = new Random();
                TitleText.Text = "Chi tiết: " + storage.StorageId;
                ProductID.Text = "Mã sản phẩm: " + storage.ProductId;
                ProductName.Text = "Tên sản phẩm: " + (random.Next(0, 100) + 1);
                ProductBrand.Text = "Hãng sản xuất: " + (random.Next(0, 100) + 1);
                ProductQuantity.Text = "Số lượng: " + storage.Quantity;
                ProductPrice.Text = "Đơn giá: " + storage.Price;
                storage.CalcTotal();
                ProductTotal.Text = "Thành tiền: " + storage.TotalPrice;
                string activeIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Active.png");
                string inactiveIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Inactive.png");
                string productImg = Path.Combine(DefaultPath.PRODUCT_IMG_PATH, "Picture.png");
                if (storage.Status == StorageDTO.Option.active && File.Exists(activeIcon))
                {
                    ProductStatus.Text = "Tình trạng: đang hoạt động";
                    ActiveIcon.Image = Image.FromFile(activeIcon);
                }
                else if (File.Exists(inactiveIcon))
                {
                    ProductStatus.Text = "Tình trạng: ngừng hoạt động";
                    ActiveIcon.Image = Image.FromFile(inactiveIcon);
                }

                if (File.Exists(productImg))
                {
                    Picture.Image = Image.FromFile(productImg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi khởi tạo " +  ex.Message
                    , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
