using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public class ButtonStyle
    {
        public Color NormalColor { get; set; }
        public Color SelectedColor { get; set; }
        public Font NormalFont { get; set; }
        public Font SelectedFont { get; set; }
        public int Height { get; set; }
        public DockStyle Dock { get; set; }

        public static ButtonStyle MenuButtonStyle => new ButtonStyle
        {
            NormalColor = Color.FromArgb(239, 248, 230),
            SelectedColor = Color.FromArgb(200, 250, 214),
            NormalFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0),
            SelectedFont = new Font("Microsoft Sans Serif", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0),
            Height = 43,
            Dock = DockStyle.Top
        };

        public static ButtonStyle ActionButtonStyle => new ButtonStyle
        {
            NormalColor = Color.FromArgb(100, 150, 200),
            SelectedColor = Color.FromArgb(80, 120, 180),
            NormalFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0),
            SelectedFont = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0),
            Height = 35,
            Dock = DockStyle.None
        };
    }
}