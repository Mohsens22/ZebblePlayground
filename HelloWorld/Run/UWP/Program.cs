namespace UWP
{
    class Program
    {
        public static void Main()
        {
            Zebble.UIRuntime.Initialize<Program>("HelloWorld");
            Windows.UI.Xaml.Application.Start((p) => new App());
        }
    }
}