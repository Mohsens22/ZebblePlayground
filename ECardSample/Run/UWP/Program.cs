namespace UWP
{
    class Program
    {
        public static void Main()
        {
            Zebble.UIRuntime.Initialize<Program>("ECardSample");
            Windows.UI.Xaml.Application.Start((p) => new App());
        }
    }
}