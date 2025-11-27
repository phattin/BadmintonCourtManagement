using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PriceRuleGUI : UserControl
    {
        private AccountDTO currentAccount;
        private PermissionDetailBUS permissiondetailBUS = new PermissionDetailBUS();
        private bool isInsert = false, isUpdate = false, isDelete = false;
        public PriceRuleGUI(AccountDTO account)
        {
            this.currentAccount = account;
            InitializeComponent();
            List<PermissionDetailDTO> permissionDetails = permissiondetailBUS.GetPermissionDetailsByFunctionId("F13");
            List<PermissionDetailDTO> accountPermissions = new List<PermissionDetailDTO>();
            foreach (var permissionDetail in permissionDetails)
            {
                if (permissionDetail.PermissionId == currentAccount.PermissionId)
                {
                    accountPermissions.Add(permissionDetail);
                }
            }
            foreach (var permission in accountPermissions)
            {
                if (permission.Option == "Insert")
                {
                    isInsert = true;
                }
                else if (permission.Option == "Update")
                {
                    isUpdate = true;
                }
                else if (permission.Option == "Delete")
                {
                    isDelete = true;
                }
            }
            buttonAdd.Visible = isInsert;
            buttonModify.Visible = isUpdate;
            buttonDelete.Visible = isDelete;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PriceRuleAddGUI addPriceRuleGUI = new PriceRuleAddGUI();
            addPriceRuleGUI.ShowDialog();
        }
    }
}
