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
            AccountDTO accountCurrent = account;
            InitializeComponent();
            CreateMenuButtons();
        }

        private void CreateMenuButtons()
        {
            menuManager = new MenuManager();
            var menuItems = new Dictionary<string, EventHandler>
            {
                { "Đặt sân", BookCourt_Click },
                { "Quản lý sân", ManageCourts_Click },
                { "Khách hàng", Customers_Click },
                { "Báo cáo", Reports_Click },
                { "Cài đặt", Settings_Click }
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

        // Event handlers for menu buttons
        private void BookCourt_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new BookCourtGUI(currentAccount));
            MessageBox.Show("Đặt sân clicked!");
        }

        private void ManageCourts_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Quản lý sân clicked!");
        }

        private void Customers_Click(object sender, EventArgs e)
        {
            OpenChildPanel(new CustomerGUI(currentAccount));
            MessageBox.Show("Khách hàng clicked!");
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Báo cáo clicked!");
        }

        private void Settings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cài đặt clicked!");
        }

        private void MainLayout_Load(object sender, EventArgs e)
        {

        }
    }
}
