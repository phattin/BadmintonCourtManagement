using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BadmintonCourtManagement.DTO;

namespace BadmintonCourtManagement.GUI
{
    public partial class CustomerGUI : UserControl
    {
        private AccountDTO currentAccount;
        private Panel customerPanel;
        private Button btn_add_customer;
        private Label lbl_title_customer;
        private DataGridView dataFrameCustomer;
        public CustomerGUI(AccountDTO currentAccount)
        {
            this.currentAccount = currentAccount;
            InitializeComponent();

            // Generate 10 random customers
            var random = new Random();
            List<CustomerDTO> list = new List<CustomerDTO>();
            for (int i = 1; i <= 10; i++)
            {
                list.Add(new CustomerDTO
                {
                    CustomerId = "KH0" + i,
                    CustomerName = $"Customer {i}",
                    CustomerPhone = $"09{random.Next(10000000, 99999999)}",
                    IsDeleted = 0
                });
            }

            dataFrameCustomer.DataSource = list;

            // Example: bind to DataGridView if needed
            // dataFrameCustomer.DataSource = list;
        }
    }
}
