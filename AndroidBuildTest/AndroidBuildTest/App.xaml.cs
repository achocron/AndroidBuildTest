using Xamarin.Forms;

namespace AndroidBuildTest
{
    public partial class App : Application
    {
        public App()
        {
            Microsoft.Azure.Mobile.MobileCenter.Start("secret", typeof(Microsoft.Azure.Mobile.Analytics.Analytics));
            InitializeComponent();

            MainPage = new AndroidBuildTestPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
