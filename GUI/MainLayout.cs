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
using GUI;

namespace BadmintonCourtManagement.GUI
{
    public partial class MainLayout : Form
    {
        private AccountDTO currentAccount;
        private UserControl currentPanel;
        private MenuManager menuManager;
        private Panel menuPanel, contentPanel;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        public MainLayout(AccountDTO account)
        {
            this.currentAccount = account;
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByPermissionId(currentAccount.PermissionId);
            List<PermissionDetailDTO> viewPermissions = new List<PermissionDetailDTO>();
            foreach (var detail in permissionDetails)
            {
                if (detail.Option == "View")
                {
                    viewPermissions.Add(detail);
                }
            }
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CreateMenuButtons1(viewPermissions);
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
                { "Sản phẩm", Product_Click},
                { "Hóa đơn", Bill_Click },
                { "Bán hàng", Sell_Click },
                { "Kho và Nhập hàng", Storage_Click },
                { "Quản lý sân", ManageCourts_Click },
                { "Giá sân", PriceRule_Click },
                { "Đặt sân", BookCourt_Click },
                { "Thống kê", Statistics_Click },
                { "Loại sản phẩm", TypeProduct_Click },
                { "Nhà cung cấp", Supplier_Click }
            };

            menuManager.CreateMenuButtons(menuPanel, menuItems);
        }

        private void CreateMenuButtons1(List<PermissionDetailDTO> viewPermissions)
        {
            menuManager = new MenuManager();
            var menuItems = new Dictionary<string, EventHandler>();

            foreach (var p in viewPermissions)
            {
                switch (p.FunctionId)
                {
                    case "F01":
                        menuItems.Add("Đặt sân", BookCourt_Click);
                        break;

                    case "F02":
                        menuItems.Add("Quản lý sân", ManageCourts_Click);
                        break;

                    case "F03":
                        menuItems.Add("Bán hàng", Sell_Click);
                        break;

                    case "F04":
                        menuItems.Add("Hóa đơn", Bill_Click);
                        break;

                    case "F05":
                        menuItems.Add("Kho và Nhập hàng", Storage_Click);
                        break;

                    case "F06":
                        menuItems.Add("Sản phẩm", Product_Click);
                        break;

                    case "F07":
                        menuItems.Add("Quản lý nhà cung cấp", Supplier_Click);
                        break;

                    case "F08":
                        menuItems.Add("Khách hàng", Customers_Click);
                        break;

                    case "F09":
                        menuItems.Add("Nhân viên", Employee_Click);
                        break;

                    case "F10":
                        menuItems.Add("Tài khoản", Account_Click);
                        break;

                    case "F11":
                        menuItems.Add("Phân quyền", Permission_Click);
                        break;

                    case "F12":
                        menuItems.Add("Thống kê", Statistics_Click);
                        break;

                    case "F13":
                        menuItems.Add("Giá sân", PriceRule_Click);
                        break;
                }
            }
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
            OpenChildPanel(new ProductSaleGUI(currentAccount));
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

        private void PriceRule_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new PriceRuleGUI(currentAccount));
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
        
        private void Supplier_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new SupplierGUI(currentAccount));
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
