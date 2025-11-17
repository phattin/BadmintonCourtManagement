using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace GUI.ComponentsGUI
{
    public partial class RoundedButton : Button
    {
        private int _borderRadius = 20;
        private int _borderSize = 0;
        private Color _borderColor = Color.PaleVioletRed;
        private Color _backgroundColor = Color.MediumSlateBlue;
        private Color _textColor = Color.White;

        public RoundedButton()
        {
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.BorderSize = 0;
            BackColor = _backgroundColor;
            ForeColor = _textColor;
            Resize += (s, e) => Invalidate();
        }

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderRadius
        {
            get => _borderRadius;
            set { _borderRadius = value; Invalidate(); }
        }

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public int BorderSize
        {
            get => _borderSize;
            set { _borderSize = value; Invalidate(); }
        }

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BorderColor
        {
            get => _borderColor;
            set { _borderColor = value; Invalidate(); }
        }

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color BackgroundColor
        {
            get => _backgroundColor;
            set { _backgroundColor = value; BackColor = value; Invalidate(); }
        }

        [Category("Custom")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public Color TextColor
        {
            get => _textColor;
            set { _textColor = value; ForeColor = value; Invalidate(); }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            float r = radius * 2F;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Rectangle rectSurface = ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -_borderSize, -_borderSize);

            int radius = _borderRadius > Height ? Height : _borderRadius;

            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, radius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, radius - _borderSize))
            using (Pen penSurface = new Pen(Parent.BackColor, _borderSize))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                // vùng bo góc
                Region = new Region(pathSurface);

                // fill nền
                e.Graphics.FillPath(new SolidBrush(_backgroundColor), pathSurface);

                // border
                if (_borderSize >= 1)
                {
                    e.Graphics.DrawPath(penBorder, pathBorder);
                }
            }

            // text
            TextRenderer.DrawText(
                e.Graphics,
                Text,
                Font,
                rectSurface,
                ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }
}
