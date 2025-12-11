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
    public partial class PriceRuleModifyGUI : Form
    {
        public PriceRuleDTO currentPriceRule { get; private set; }
        PriceRuleBUS bus = new PriceRuleBUS();
        public PriceRuleModifyGUI(PriceRuleDTO data)
        {
            InitializeComponent();
            this.currentPriceRule = data;
            FillDataToControls();
        }

        private void FillDataToControls()
        {
            numericUpDown1.Value = (decimal)currentPriceRule.Price;

            dateTimePickerStartTime.Value = DateTime.Today.Add(currentPriceRule.StartTime.ToTimeSpan());
            dateTimePickerEndTime.Value = DateTime.Today.Add(currentPriceRule.EndTime.ToTimeSpan());

            if (currentPriceRule.StartDate != null)
            {
                dateTimePickerStartDate.Checked = true;
                dateTimePickerStartDate.Value = currentPriceRule.StartDate.Value.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dateTimePickerStartDate.Checked = false;
            }
            if (currentPriceRule.EndDate != null)
            {
                dateTimePickerEndDate.Checked = true;
                dateTimePickerEndDate.Value = currentPriceRule.EndDate.Value.ToDateTime(TimeOnly.MinValue);
            }
            else
            {
                dateTimePickerEndDate.Checked = false;
            }

            comboBoxEndType.Text = currentPriceRule.EndType;
            textBoxDes.Text = currentPriceRule.Description;
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

            PriceRuleDTO updateDto = new PriceRuleDTO(currentPriceRule.PriceRuleId, price, startTime, endTime, startDate, endDate, endType, description, currentPriceRule.IsActive);
            Dictionary<string, string> errors = bus.ValidatePriceRule(updateDto);

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
                List<PriceRuleDTO> allRules = bus.GetAllPriceRules();
                var overlappingRule = allRules.FirstOrDefault(r =>
                    r.EndType == endType &&
                    r.PriceRuleId != currentPriceRule.PriceRuleId &&
                    (startTime < r.EndTime && endTime > r.StartTime) &&
                    (
                       (startDate == null || r.EndDate == null || startDate <= r.EndDate) &&
                       (endDate == null || r.StartDate == null || endDate >= r.StartDate)
                    )
                );

                if (overlappingRule != null)
                {
                    string msg = $"Bị trùng với mã: {overlappingRule.PriceRuleId}\n" +
                                 $"Loại: {overlappingRule.EndType}\n" +
                                 $"Giờ: {overlappingRule.StartTime} - {overlappingRule.EndTime}\n" +
                                 $"Ngày: {(overlappingRule.StartDate?.ToString() ?? "NULL")} - {(overlappingRule.EndDate?.ToString() ?? "NULL")}";

                    MessageBox.Show(msg, "Tìm thấy nguyên nhân trùng!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (bus.UpdatePriceRule(updateDto))
                {
                    MessageBox.Show("Sửa giá sân thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.currentPriceRule = updateDto;
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại. Vui lòng thử lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
