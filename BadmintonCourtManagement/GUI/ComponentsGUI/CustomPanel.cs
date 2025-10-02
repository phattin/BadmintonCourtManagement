using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Drawing;
using System.ComponentModel;  // cần để dùng Browsable, Category

namespace BadmintonCourtManagement.GUI
{
    public class CustomPanel : Panel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        private int _borderRadius = 20;

        [Browsable(true)]
        [Category("Custom")]
        [Description("Độ bo góc của panel")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get { return _borderRadius; }
            set
            {
                _borderRadius = value;
                this.Invalidate(); // refresh lại control
            }
        }

        public CustomPanel()
        {
            this.Resize += (s, e) => ApplyRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ApplyRegion();
        }

        private void ApplyRegion()
        {
            if (this.Width > 0 && this.Height > 0)
            {
                this.Region = Region.FromHrgn(CreateRoundRectRgn(
                    0, 0, this.Width, this.Height, _borderRadius, _borderRadius));
            }
        }
    }
}
