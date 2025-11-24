using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GUI.ComponentsGUI
{
    public partial class RoundedTableLayoutPanel : TableLayoutPanel
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private int _borderRadius = 20;

        [Browsable(true)]
        [Category("Appearance")]
        [Description("Độ bo góc của TableLayoutPanel")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                ApplyRegion();
                Invalidate();
            }
        }

        public RoundedTableLayoutPanel()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            ApplyRegion();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            ApplyRegion();
        }

        private void ApplyRegion()
        {
            if (!IsHandleCreated || Width <= 0 || Height <= 0)
                return;

            IntPtr regionHandle = CreateRoundRectRgn(
                0, 0, Width + 1, Height + 1,
                _borderRadius, _borderRadius
            );

            this.Region = Region.FromHrgn(regionHandle);
        }
    }
}
