using BadmintonCourtManagement.DAO;
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
                importBillID.Text += " " + storage.ImportBillId;
                productID.Text += " " + storage.ProductId;
                quantity.Text += " " + storage.Quantity;
                price.Text += " " + additional.beautyMoney(storage.Price);
                storage.CalcTotal();
                totalPrice.Text += " " + additional.beautyMoney(storage.TotalPrice);
                date.Text += " " + storage.CreatedAt.ToString("dd/MM/yyyy");
                string activeIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Active.png");
                string inactiveIcon = Path.Combine(DefaultPath.ICON_IMG_PATH, "Inactive.png");

                ProductDTO productDTO = new ProductDAO().GetProductById(storage.ProductId);
                string basePath = AppDomain.CurrentDomain.BaseDirectory;
                string projectRoot = Path.GetFullPath(Path.Combine(basePath, @"..\..\..\"));
                string productImg = Path.Combine(projectRoot, "Img", "Product", productDTO.ProductImg);
                if (!File.Exists(productImg))
                {
                    productImg = Path.Combine(projectRoot, "Img", "Product", "DefaultProductImage.jpg");
                }
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

        private void TitleText_Click(object sender, EventArgs e)
        {

        }
    }
}
