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
        private PriceRuleBUS priceruleBUS = new PriceRuleBUS();
        private BindingList<PriceRuleDTO> priceRuleList;
        public PriceRuleGUI(AccountDTO account)
        {
            this.currentAccount = account;
            InitializeComponent();
            ConfigureDataGridView();
            LoadData();
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

        private void ConfigureDataGridView()
        {
            dataGridView1.AutoGenerateColumns = false;

            ID.DataPropertyName = "PriceRuleId";
            StartTime.DataPropertyName = "StartTime";
            EndTime.DataPropertyName = "EndTime";
            StartDate.DataPropertyName = "StartDate";
            EndDate.DataPropertyName = "EndDate";
            EndType.DataPropertyName = "EndType";
            Price.DataPropertyName = "Price";
            Status.DataPropertyName = "IsActive";

            dataGridView1.CellFormatting += DataGridView1_CellFormatting;
        }

        public void LoadData()
        {
            try
            {
                var list = priceruleBUS.GetAllPriceRules();

                priceRuleList = new BindingList<PriceRuleDTO>(list);

                dataGridView1.DataSource = priceRuleList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
            }
        }

        private void DataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.Value == null) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price")
            {
                if (e.Value is double price)
                {
                    e.Value = price.ToString("#,##0") + " VNĐ";
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "StartDate" ||
                dataGridView1.Columns[e.ColumnIndex].Name == "EndDate")
            {
                if (e.Value is DateOnly date)
                {
                    e.Value = date.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Status")
            {
                int status = Convert.ToInt32(e.Value);
                if (status == 1)
                {
                    e.Value = "Đang hoạt động";
                    e.CellStyle.ForeColor = Color.Green;
                }
                else
                {
                    e.Value = "Ngưng hoạt động";
                    e.CellStyle.ForeColor = Color.Red;
                }
                e.FormattingApplied = true;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            PriceRuleAddGUI addPriceRuleGUI = new PriceRuleAddGUI();
            if (addPriceRuleGUI.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonModify_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            PriceRuleDTO selectedItem = selectedRow.DataBoundItem as PriceRuleDTO;
            if (selectedItem == null) return;

            if (selectedItem.IsActive != 1)
            {
                MessageBox.Show("Giá sân này đã ngưng hoạt động.\nKhông thể thực hiện chỉnh sửa.",
                                "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            PriceRuleModifyGUI modifyForm = new PriceRuleModifyGUI(selectedItem);

            if (modifyForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridView1.SelectedRows[0];
            var selectedItem = selectedRow.DataBoundItem as PriceRuleDTO;

            if (selectedItem == null) return;

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc chắn muốn xóa không?\n\nHành động này không thể hoàn tác.",
                "Xác nhận xóa",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    if (priceruleBUS.DeletePriceRule1(selectedItem.PriceRuleId))
                    {
                        MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể xóa dữ liệu này.\nCó thể dữ liệu đang được sử dụng trong hóa đơn hoặc đặt sân.\n\nChi tiết: " + ex.Message, "Lỗi hệ thống", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Function")
            {
                var selectedItem = dataGridView1.Rows[e.RowIndex].DataBoundItem as PriceRuleDTO;
                if (selectedItem != null)
                {
                    PriceRuleDescriptionGUI desForm = new PriceRuleDescriptionGUI(selectedItem);
                    desForm.ShowDialog();
                }
            }
        }
    }
}
