using System;
using System.ComponentModel;
using System.Windows.Forms;


namespace BadmintonCourtManagement.GUI.ComponentsGUI
{
    public partial class TimePicker : UserControl
    {
        public event EventHandler ValueChanged;
        private TextBox txtTime;
        private Button btnDropDown;
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public DateTime SelectedTime { get; set; }

        public TimePicker()
        {
            txtTime = new TextBox { Dock = DockStyle.Fill, ReadOnly = true };
            btnDropDown = new Button { Text = "▼", Dock = DockStyle.Right, Width = 25 };
            this.Controls.Add(txtTime);
            this.Controls.Add(btnDropDown);

            btnDropDown.Click += BtnDropDown_Click;

            SelectedTime = DateTime.Now;
            UpdateText();
        }

        private void BtnDropDown_Click(object sender, EventArgs e)
        {
            using (var dialog = new TimePickerDialog(SelectedTime))
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    SelectedTime = dialog.SelectedTime;
                    UpdateText();
                    OnValueChanged();
                }
            }
        }

        private void UpdateText()
        {
            txtTime.Text = SelectedTime.ToString("hh:mm tt");
        }

        protected virtual void OnValueChanged()
        {
            ValueChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
