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
    public partial class MainLayout : Form
    {
        private AccountDTO currentAccount;
        private UserControl currentPanel;
        private MenuManager menuManager;
        private Panel menuPanel, contentPanel;
        public MainLayout(AccountDTO account)
        {
            this.currentAccount = account;
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CreateMenuButtons();
        }

        private void CreateMenuButtons()
        {
            menuManager = new MenuManager();
            var menuItems = new Dictionary<string, EventHandler>
            {
                { "Khách hàng", Customers_Click },
                { "Phân quyền", Permission_Click },
                { "Tài khoản", Account_Click },
                { "Nhân viên", Employee_Click },
                {"Sản phẩm", Product_Click},
                { "Hóa đơn", Bill_Click },
                { "Bán hàng", Sell_Click },
                { "Kho và Nhập hàng", Storage_Click },
                { "Quản lý sân", ManageCourts_Click },
                { "Đặt sân", BookCourt_Click },
                { "Thống kê", Statistics_Click },
                { "Loại sản phẩm", TypeProduct_Click }
            };

            menuManager.CreateMenuButtons(menuPanel, menuItems);
        }

        private void OpenChildPanel(UserControl childPanel)
        {
            // Remove current panel if exists
            if (currentPanel != null)
            {
                contentPanel.Controls.Remove(currentPanel);
                currentPanel.Dispose();
            }

            // Add new panel
            currentPanel = childPanel;
            contentPanel.Controls.Add(childPanel);
            childPanel.Dock = DockStyle.Fill;
            //childPanel.BringToFront();

            // Keep menu panel on top
            //menuPanel.BringToFront();
        }

        private void Permission_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new PermissionGUI(currentAccount));
        }
        
        private void Account_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tài khoản clicked!");
        }

        private void Bill_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hóa đơn clicked!");
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bán hàng clicked!");
        }

        // Event handlers for menu buttons
        private void BookCourt_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new BookCourtGUI(currentAccount));
            // MessageBox.Show("Đặt sân clicked!");
        }

        private void ManageCourts_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new CourtManagementGUI(currentAccount));
            //MessageBox.Show("Quản lý sân clicked!");
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new CustomerGUI(currentAccount));
            // MessageBox.Show("form: " + this.Size.ToString() + "\ncontentPanel: " + contentPanel.Size.ToString() + "\ncurrentPanel: " + currentPanel.Size.ToString());
        }

        private void Storage_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new storageGUI(currentAccount));
        }

        private void Employee_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new EmployeeGUI(currentAccount));
        }

        private void Product_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ProductGUI(currentAccount));
        }

        private void Statistics_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new StatisticGUI(currentAccount));
        }
        private void TypeProduct_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new TypeProductGUI(currentAccount));
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }

        private void contentPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuPanel_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
