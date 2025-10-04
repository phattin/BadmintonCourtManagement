using System;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI.ComponentsGUI
{
    public class TwoDigitNumericUpDown : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            this.Text = this.Value.ToString("00"); // ép thành 2 chữ số
        }
    }
    public class TimePickerDialog : Form
    {
        private NumericUpDown numHour, numMinute;
        private Button btnOK, btnCancel;

        public DateTime SelectedTime { get; private set; }

        public TimePickerDialog(DateTime initialTime)
        {
            this.Text = "Chọn giờ";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;
            this.Width = 350;
            this.Height = 250;  

            numHour = new TwoDigitNumericUpDown
            {
                Minimum = 0,
                Maximum = 23,
                Value = initialTime.Hour,
                Left = 40,
                Top = 40,
                Width = 80,
                Font = new System.Drawing.Font("Segoe UI", 14)
            };

            numMinute = new TwoDigitNumericUpDown
            {
                Minimum = 0,
                Maximum = 59,
                Value = initialTime.Minute,
                Left = 150,
                Top = 40,
                Width = 80,
                Font = new System.Drawing.Font("Segoe UI", 14)
            };
            numHour.ValueChanged += (s, e) =>
            {
                numHour.Text = numHour.Value.ToString("00");
            };
            numMinute.ValueChanged += (s, e) =>
            {
                numMinute.Text = numMinute.Value.ToString("00");
            };
            // Nút OK
            btnOK = new Button
            {
                Text = "OK",
                Left = 60,
                Top = 120,
                Width = 80,
                Height = 40,
                DialogResult = DialogResult.OK
            };

            // Nút Cancel
            btnCancel = new Button
            {
                Text = "Cancel",
                Left = 180,
                Top = 120,
                Width = 80,
                Height = 40,
                DialogResult = DialogResult.Cancel
            };

            this.Controls.Add(numHour);
            this.Controls.Add(numMinute);
            this.Controls.Add(btnOK);
            this.Controls.Add(btnCancel);

            this.AcceptButton = btnOK;
            this.CancelButton = btnCancel;

            btnOK.Click += (s, e) =>
            {
                int hour = (int)numHour.Value;
                int minute = (int)numMinute.Value;
                SelectedTime = new DateTime(1, 1, 1, hour, minute, 0);
            };
        }
    }
}
