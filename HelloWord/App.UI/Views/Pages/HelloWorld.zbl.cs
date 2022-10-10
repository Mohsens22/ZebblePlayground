using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Zebble;

namespace UI.Pages
{
    partial class HelloWorld
    {
        public override Task OnInitializing()
        {
            return base.OnInitializing();
            // do stuff befor page initializing...

        }
        public override Task OnInitialized()
        {
            Zebble.Device.Screen.DarkMode = true;
            return base.OnInitialized();
            // do stuff befor page rendered and after initializing...
        }
        public override async Task OnRendered()
        {
            await base.OnRendered();
            // do stuff after page rendered and shown...
        }

    }
}
