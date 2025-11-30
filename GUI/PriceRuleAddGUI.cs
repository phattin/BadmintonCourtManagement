using BadmintonCourtManagement.BUS;
using BadmintonCourtManagement.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class PriceRuleAddGUI : Form
    {
        public PriceRuleDTO NewPriceRule { get; private set; }
        PriceRuleBUS bus = new PriceRuleBUS();
        public PriceRuleAddGUI()
        {
            InitializeComponent();
            comboBoxEndType.Text = "Weekday";
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            double price = (double)numericUpDown1.Value;
            TimeOnly startTime = TimeOnly.FromDateTime(dateTimePickerStartTime.Value);
            TimeOnly endTime = TimeOnly.FromDateTime(dateTimePickerEndTime.Value);
            DateOnly? startDate = null;
            if (dateTimePickerStartDate.Checked)
            {
                startDate = DateOnly.FromDateTime(dateTimePickerStartDate.Value);
            }
            DateOnly? endDate = null;
            if (dateTimePickerEndDate.Checked)
            {
                endDate = DateOnly.FromDateTime(dateTimePickerEndDate.Value);
            }
            string endType = comboBoxEndType.Text.Trim();
            string description = textBoxDes.Text.Trim();

            PriceRuleDTO dto = new PriceRuleDTO(price, startTime, endTime, startDate, endDate, endType, description, 1);
            Dictionary<string, string> errors = bus.ValidatePriceRule(dto);

            if (errors.Count > 0)
            {
                if (errors.ContainsKey("EndTime"))
                    errorProvider1.SetError(dateTimePickerEndTime, errors["EndTime"]);

                if (errors.ContainsKey("EndDate"))
                    errorProvider1.SetError(dateTimePickerEndDate, errors["EndDate"]);

                return;
            }
            try
            {
                string newId = bus.GeneratePriceRuleId();
                PriceRuleDTO newPriceRule = new PriceRuleDTO(newId, price, startTime, endTime, startDate, endDate, endType, description, 1);

                if (bus.InsertPriceRule(newPriceRule))
                {
                    MessageBox.Show("Thêm giá sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NewPriceRule = newPriceRule;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
