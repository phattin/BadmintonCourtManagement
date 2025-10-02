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
            this.SizeChanged += (s, e) => responsive(); // Add this line
        }

        private void responsive()
        {
            // int num = this.Size.Width - (btn_add_customer.Location.X + 33);
            if (this.Size.Width < 1036)
            {
                btn_add_customer.Size = new Size(118, 39);
                // btn_add_customer.Location = new Point(this.Size.Width - num, 41);
                // btn_add_customer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btn_add_customer.Font = new Font("Segoe UI Semibold", 9.4F, FontStyle.Bold, GraphicsUnit.Point, 0);
                lbl_title_customer.Font = new Font("Segoe UI Semibold", 22F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
            else
            {
                btn_add_customer.Size = new Size(151, 50);
                // btn_add_customer.Location = new Point(1521, 45);
                // btn_add_customer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                btn_add_customer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
                lbl_title_customer.Font = new Font("Segoe UI Semibold", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            }
        }
        
    }
}
