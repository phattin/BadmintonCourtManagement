using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BadmintonCourtManagement.GUI
{
    public class MenuManager
    {
        private MenuButton selectedButton;
        private readonly List<MenuButton> menuButtons;

        public MenuManager()
        {
            menuButtons = new List<MenuButton>();
        }

        public void AddButton(MenuButton button)
        {
            menuButtons.Add(button);
            button.Click += OnMenuButtonClick;
        }

        private void OnMenuButtonClick(object sender, EventArgs e)
        {
            SelectButton((MenuButton)sender);
        }

        public void SelectButton(MenuButton button)
        {
            // Deselect previously selected button
            selectedButton?.Deselect();
            
            // Select new button
            selectedButton = button;
            selectedButton.Select();
        }

        public void CreateMenuButtons(Panel container, Dictionary<string, EventHandler> menuItems)
        {
            container.Controls.Clear();
            menuButtons.Clear();

            foreach (var item in menuItems)
            {
                var button = new MenuButton(item.Key);
                button.Click += item.Value; // Add custom event handler
                AddButton(button);
                container.Controls.Add(button);
            }
        }
    }
}