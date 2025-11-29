using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public class ButtonStyle
    {
        public Color NormalColor { get; set; }
        public Color SelectedColor { get; set; }
        public Color ForeColor { get; set; }
        public Color SelectedForeColor { get; set; }
        public Font NormalFont { get; set; }
        public Font SelectedFont { get; set; }
        public int Height { get; set; }
        public DockStyle Dock { get; set; }

        public static ButtonStyle MenuButtonStyle => new ButtonStyle
        {
            // original normal color: 239, 248, 230
            NormalColor = Color.FromArgb(229, 228, 226),
            SelectedColor = Color.FromArgb(239, 248, 230), //200, 250, 214
            ForeColor = Color.Black,
            SelectedForeColor = Color.Black,
            NormalFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
            SelectedFont = new Font("Tahoma", 12F, FontStyle.Regular, GraphicsUnit.Point, 0),
            Height = 50,
            Dock = DockStyle.Top
        };

        public static ButtonStyle ActionButtonStyle => new ButtonStyle
        {
            NormalColor = Color.FromArgb(100, 150, 200),
            SelectedColor = Color.FromArgb(80, 120, 180),
            ForeColor = Color.Black,
            SelectedForeColor = Color.Black,
            NormalFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
            SelectedFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
            Height = 35,
            Dock = DockStyle.None
        };
    }
}
