using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zebble;

namespace UI.Pages
{
    partial class Home
    {
        public override async Task OnInitializing()
        {
            await base.OnInitializing();
        }

        public async Task ChangeThemeBtnTapped()
        {
            Zebble.Device.Screen.DarkMode = !Zebble.Device.Screen.DarkMode;
            await UIContext.RefreshUI();
        }
    }
}
