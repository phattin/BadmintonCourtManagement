using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;


namespace BadmintonCourtManagement.GUI
{
    public partial class LoginGUI : Form
    {

        private List<StorageDTO> storageList = new List<StorageDTO>();
        private List<ProductDTO> productList = new List<ProductDTO>();
        private List<BrandDTO> brandList = new List<BrandDTO>();
        private List<ImportBillDTO> importBillList = new List<ImportBillDTO>();
        // private List<ImportBillDTO>
        private List<TypeProductDTO> typeProductList = new List<TypeProductDTO>();

        public LoginGUI()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void LoginGUI_Load(object sender, EventArgs e)
        {
            storageList = StorageBUS.GetAllStorages();
            productList = new ProductBUS().GetAllProducts();
            brandList = new BrandBUS().GetAllBrands();
            importBillList = new BillImportBUS().GetAllImportBills();
            typeProductList = new TypeProductBUS().GetAllTypeProducts();
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblBrand_Click(object sender, EventArgs e)
        {

        }

        private void pLogo_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bSignIn_Click(sender, e);
            }
        }



        private void pIconPassword_Click(object sender, EventArgs e)
        {

        }

        private void bSignIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // Kiểm tra textbox trống
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            try
            {
                AccountBUS bus = new AccountBUS();
                AccountDTO account = bus.GetAccount(username, password);

                if (account != null)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Chuyển sang MainLayout
                    MainLayout main = new MainLayout(account, storageList, typeProductList, productList, brandList, importBillList);
                    main.Show();
                    // Khi MainLayout đóng → LoginGUI cũng đóng
                    main.FormClosed += (s, args) => this.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tài khoản không tồn tại hoặc mật khẩu sai!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đăng nhập: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pSignIn_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
