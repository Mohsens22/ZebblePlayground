using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;
using Olive;
using UI.Pages;
using Zebble;
using static Zebble.Device.Screen;

namespace UI
{
    partial class UIContext
    {
        const bool TEST_MODE = false; // Also change Exception Settings: Common Language Runtime Exceptions (Ctrl + Alt + E)
        // public const bool ProMode = true; // remove at production
        static DateTime LastActiveUtc = LocalTime.UtcNow;

        static bool IsBusy;
        public static readonly AsyncEvent Refreshed = new AsyncEvent();
        static DateTime LastOnline;

        public readonly static Bindable<bool> Online = new Bindable<bool>();


        public static bool IsSmallScreen() => View.Root.ActualHeight < 600;

        public static Color Background => IsDark() ? "#333333" : Colors.White;
        public static Color Foreground => IsDark() ? Colors.White : "#333333";

        public static async Task ApplyStyleChoice()
        {
            View.Root.Background(Background);
#if UWP
            // Android has a bug in light theme and doesn't apply foreground at all. It's a zebble issue. 
            // And I haven't tested iOS since it looks good enough
            StatusBar.BackgroundColor = Background;
            StatusBar.ForegroundColor = Foreground;
#endif

            var css = View.Root.CssClass.OrEmpty().Split(' ').Trim()
                .Except("large-text")
                .Except("dark-mode").Concat("dark-mode".OnlyWhen(IsDark()))
                .Except("small-screen").Concat("small-screen".OnlyWhen(IsSmallScreen()))
                .Trim().ToString(" ");

            if (View.Root.CssClass != css)
                await View.Root.SetCssClass(css);
        }

        public static async Task ClearCache()
        {
            foreach (var item in View.Root.AllChildren.OfType<Page>().Except(Nav.ActivePages).ToArray())
                await item.RemoveSelf();
            Nav.DisposeCache();
        }




        public static async Task RefreshUI(bool reload = true)
        {
            while (IsBusy) await Task.Delay(20);
            IsBusy = true;
            await ClearCache();
            try
            {
                await UIWorkBatch.Run(() => ApplyStyleChoice(), awaitNative: true);
                await Refreshed.Raise();
            }
            finally { IsBusy = false; }
        }

        public static bool IsTestMode() => TEST_MODE;


        /// <summary>
        /// Determines whether the user is offline now, and has not been online since 10 seconds ago.
        /// </summary>



        public static bool IsDark()
        {
            return Zebble.Device.Screen.DarkMode;
        }

        /// <returns>"white" if in dark mode otherwise "black"</returns>
        public static string WhetherThemeIcon() => WhetherTheme("white", "black");

        /// <returns>darkValue if in dark mode otherwise lightValue.</returns>
        public static T WhetherTheme<T>(T darkValue, T lightValue) => IsDark() ? darkValue : lightValue;


    }
}