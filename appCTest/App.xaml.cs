using Xamarin.Forms;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;

namespace appCTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new appCTestPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start("android=60627664-ded5-4669-8836-ab93e16d2053;" + "uwp={Your UWP App secret here};" + "ios={Your iOS App secret here}", typeof(Analytics), typeof(Crashes));
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
