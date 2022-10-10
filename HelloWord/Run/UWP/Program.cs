namespace UWP
{
    class Program
    {
        public static void Main()
        {
            Zebble.UIRuntime.Initialize<Program>("HelloWord");
            Windows.UI.Xaml.Application.Start((p) => new App());
        }
    }
}