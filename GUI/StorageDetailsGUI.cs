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
                Additional additional = new Additional();
                TitleText.Text += " " + storage.StorageId;
                importBillID.Text += " " + storage.ImportBillDetailId;
                productID.Text += " " + storage.ProductId;
                quantity.Text += " " + storage.Quantity;
                price.Text += " " + additional.beautyMoney(storage.Price);
                storage.CalcTotal();
                totalPrice.Text += " " + additional.beautyMoney(storage.TotalPrice);
                date.Text += " " + storage.CreatedAt.ToString("dd/MM/yyyy");
                string activeIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Active.png");
                string inactiveIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Inactive.png");
                string productImg = Path.Combine(DefaultPath.PRODUCT_IMG_PATH, "Picture.png");
                if (storage.Status == StorageDTO.Option.active && File.Exists(activeIcon))
                {
                    status.Text += " đang hoạt động";
                    status.Image = Image.FromFile(activeIcon);
                }
                else if (File.Exists(inactiveIcon))
                {
                    status.Text += " ngừng hoạt động";
                    status.Image = Image.FromFile(inactiveIcon);
                }

                if (File.Exists(productImg))
                {
                    productImage.Image = Image.FromFile(productImg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xảy ra khi khởi tạo " + ex.Message
                    , "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
