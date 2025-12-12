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
            TimeOnly startTime = new TimeOnly(dateTimePickerStartTime.Value.Hour, dateTimePickerStartTime.Value.Minute, 0);
            TimeOnly endTime = new TimeOnly(dateTimePickerEndTime.Value.Hour, dateTimePickerEndTime.Value.Minute, 0);
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
                    errorProvider1.SetError(labelEndTime, errors["EndTime"]);

                if (errors.ContainsKey("EndDate"))
                    errorProvider1.SetError(labelEndDate, errors["EndDate"]);

                return;
            }
            try
            {
                PriceRuleDTO overlappingRule = bus.CheckOverlap(dto);
                if (overlappingRule != null)
                {
                    string msg = $"Bị trùng với mã: {overlappingRule.PriceRuleId}\n" +
                                 $"Loại: {overlappingRule.EndType}\n" +
                                 $"Giờ: {overlappingRule.StartTime} - {overlappingRule.EndTime}\n" +
                                 $"Ngày: {(overlappingRule.StartDate?.ToString() ?? "NULL")} - {(overlappingRule.EndDate?.ToString() ?? "NULL (Áp dụng cho tất cả các ngày)")}";

                    MessageBox.Show(msg, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string newId = bus.GeneratePriceRuleId();
                PriceRuleDTO newPriceRule = new PriceRuleDTO(newId, price, startTime, endTime, startDate, endDate, endType, description, 1);
                if (bus.InsertPriceRule(newPriceRule))
                {
                    MessageBox.Show("Thêm giá sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.NewPriceRule = newPriceRule;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
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
