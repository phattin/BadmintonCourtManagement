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
using Microsoft.VisualBasic.Logging;

namespace BadmintonCourtManagement.GUI
{
    public partial class MainLayout : Form
    {
        private AccountDTO currentAccount;
        private UserControl currentPanel;
        private MenuManager menuManager;
        private Panel menuPanel, contentPanel;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();

        private List<StorageDTO> storageList;
        private List<ProductDTO> productList = new List<ProductDTO>();
        private List<BrandDTO> brandList = new List<BrandDTO>();
        private List<ImportBillDTO> importBillList = new List<ImportBillDTO>();
        private List<CourtDTO> courtList = new List<CourtDTO>();
        private List<EmployeeDTO> employeeList = new List<EmployeeDTO>();

        private List<TypeProductDTO> typeProductList = new List<TypeProductDTO>();
        private List<BillBookingDTO> listBillBookings = new List<BillBookingDTO>();
        private List<BillProductDTO> listBillProduct = new List<BillProductDTO>();
        private List<ImportBillDTO> listImportBill = new List<ImportBillDTO>();
        private List<BillProductDetailDTO> listBillDetails = new List<BillProductDetailDTO>();
        private List<ProductDTO> listProducts = new List<ProductDTO>();
        private List<BookingDTO> listBooking = new List<BookingDTO>();
        private List<CourtDTO> listCourts = new List<CourtDTO>();
        private List<BillImportDetailDTO> listImportDetails;

        public MainLayout(AccountDTO account, List<StorageDTO> storageList, List<TypeProductDTO> typeProductList, List<ProductDTO> productList, List<BrandDTO> brandList, List<ImportBillDTO> importBillList, List<CourtDTO> courtList, List<EmployeeDTO> employeeList, List<BillBookingDTO> listBillBookings, List<BillProductDTO> listBillProduct, List<ImportBillDTO> listImportBill, List<BillProductDetailDTO> listBillDetails, List<ProductDTO> listProducts, List<BookingDTO> listBooking, List<CourtDTO> listCourts, List<BillImportDetailDTO> listImportDetails)
        {
            this.typeProductList = typeProductList;
            this.currentAccount = account;
            this.storageList = storageList;
            this.listBillBookings = listBillBookings;
            this.listBillProduct = listBillProduct;
            this.listImportBill = listImportBill;
            this.listBillDetails = listBillDetails;
            this.listProducts = listProducts;
            this.listCourts = listCourts;
            this.listBooking = listBooking;
            this.listImportDetails = listImportDetails;
            this.productList = productList;
            this.brandList = brandList;
            this.importBillList = importBillList;
            this.courtList = courtList;
            InitializeComponent();
            Session.CurrentUser = account;
            Session.OnPermissionChanged += ReloadMenu;
            ReloadMenu();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.employeeList = employeeList;
        }

        private void ReloadMenu()
        {
            menuPanel.Controls.Clear();

            List<PermissionDetailDTO> newPermissions = permissiondetailBUS.GetPermissionDetailsByPermissionId(Session.CurrentUser.PermissionId);
            List<PermissionDetailDTO> viewPermissions = newPermissions.FindAll(p => p.Option == "View");

            CreateMenuButtons1(viewPermissions);
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

                    case "F14":
                        menuItems.Add("Thương hiệu", Brand_Click);
                        break;
                        
                    case "F15":
                        menuItems.Add("Quản lý loại sản phẩm", TypeProduct_Click);
                        break;
                    case "F16":
                        menuItems.Add("Hóa đơn đặt sân", BillBooking_Click);
                        break;
                }
            }

            menuItems.Add("Đăng xuất", Logout_Click);
            var firstAction = menuItems.Values.FirstOrDefault();

            var reversedMenuItems = menuItems.Reverse().ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            menuManager.CreateMenuButtons(menuPanel, reversedMenuItems);
            if (firstAction != null)
            {
                firstAction.Invoke(this, EventArgs.Empty);
            }
        }

        private void OpenChildPanel(UserControl childPanel)
        {
            // Remove current panel if exists
            if (currentPanel != null)
            {
                contentPanel!.Controls.Remove(currentPanel!);
                currentPanel.Dispose();
            }

            // Add new panel
            currentPanel = childPanel;
            contentPanel!.Controls.Add(childPanel);
            childPanel.Dock = DockStyle.Fill;
            //childPanel.BringToFront();

            // Keep menu panel on top
            //menuPanel.BringToFront();
        }

        private void Logout_Click(object? sender, EventArgs e)
        {
            DialogResult status = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (status == DialogResult.Yes)
            {
                // this.Close();
                LoginGUI loginGUI = new LoginGUI();
                loginGUI.Show();
                this.Hide();
            }
        }

        private void Brand_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new BrandGUI(currentAccount, brandList));
        }
        private void Permission_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new PermissionGUI(currentAccount));
        }
        
        private void Account_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new AccountGUI(currentAccount));
        }

        private void Bill_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new BillProductGUI(currentAccount));
        }

        private void Sell_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new ProductSaleGUI(currentAccount, storageList));
        }

        // Event handlers for menu buttons
        private void BookCourt_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new BookCourtGUI(currentAccount));
            // MessageBox.Show("Đặt sân clicked!");
        }

        private void ManageCourts_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new CourtManagementGUI(currentAccount, courtList));
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

        private void Storage_Click(object? sender, EventArgs e)
        {
            storageList = StorageBUS.GetAllStorages();
            OpenChildPanel(new storageGUI(currentAccount, storageList, importBillList));
        }

        private void Employee_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new EmployeeGUI(currentAccount, employeeList));
        }

        private void Product_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new ProductGUI(currentAccount, productList));
        }

        private void Statistics_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new StatisticMainGUI(listBillBookings,listBillProduct,listImportBill, listBillDetails,listProducts,listBooking,listCourts, listImportDetails));
        }
        private void TypeProduct_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new TypeProductGUI(currentAccount, typeProductList));
        }
        
        private void Supplier_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new SupplierGUI(currentAccount));
        }
        // private void BillProduct_Click(object? sender, EventArgs e)
        // {
        //     OpenChildPanel(new BillProductGUI(currentAccount));
        // }
        private void BillBooking_Click(object? sender, EventArgs e)
        {
            OpenChildPanel(new hoadonGUI(currentAccount));
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
