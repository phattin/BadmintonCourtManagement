using System;
using System.Drawing;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public class MenuButton : Button
    {
        private readonly ButtonStyle style;
        public bool IsSelected { get; private set; }

        public MenuButton(string text, ButtonStyle buttonStyle)
        {
            Text = text;
            style = buttonStyle;
            SetupButton();
            Deselect(); // Start in normal state
        }

        public MenuButton(string text) : this(text, ButtonStyle.MenuButtonStyle) {}

        private void SetupButton()
        {
            Dock = style.Dock;
            FlatStyle = FlatStyle.Flat;
            Height = style.Height;
            UseVisualStyleBackColor = false;
            FlatAppearance.BorderSize = 0;
        }

        public void Select()
        {
            IsSelected = true;
            BackColor = style.SelectedColor;
            Font = style.SelectedFont;
        }

        public void Deselect()
        {
            IsSelected = false;
            BackColor = style.NormalColor;
            Font = style.NormalFont;
        }
    }
}
