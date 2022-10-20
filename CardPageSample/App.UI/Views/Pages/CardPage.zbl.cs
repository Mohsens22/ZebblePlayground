using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zebble;

namespace UI.Pages
{
    partial class CardPage
    {
        public async Task LightThemeButtonTapped()
        {
            Zebble.Device.Screen.DarkMode = false;
            await UIContext.RefreshUI();
        }

        public async Task DarkThemeButtonTapped()
        {
            Zebble.Device.Screen.DarkMode = true;
            await UIContext.RefreshUI();
        }
    }


}
