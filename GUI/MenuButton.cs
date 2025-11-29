using System;
using System.Drawing;
using System.Windows.Forms;
using GUI.ComponentsGUI;

namespace BadmintonCourtManagement.GUI
{
    public class MenuButton : RoundedButton
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
            // UseVisualStyleBackgroundColor = false;
            FlatAppearance.BorderSize = 0;
            Margin = new Padding(5, 0, 5, 0);
        }

        public void Select()
        {
            IsSelected = true;
            BackgroundColor = style.SelectedColor;
            Font = style.SelectedFont;
            ForeColor = style.SelectedForeColor;
        }

        public void Deselect()
        {
            IsSelected = false;
            BackgroundColor = style.NormalColor;
            Font = style.NormalFont;
            ForeColor = style.ForeColor;
        }
    }
}
