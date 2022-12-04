namespace MauiSandbox.Xamarin.UWP
{
    public sealed partial class MainPage
    {
        public MainPage()
        {
            this.InitializeComponent();

            LoadApplication(new MauiSandbox.Xamarin.App());
        }
    }
}
