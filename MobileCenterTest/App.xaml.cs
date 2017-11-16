using Xamarin.Forms;
using MobileCenterTest.Views;
using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

namespace MobileCenterTest
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MobileCenter.Start("ios=%MOBILE_CENTER_IOS%;",  typeof(Analytics), typeof(Crashes));
            MainPage = new NavigationPage(new TopView())
            {
                BackgroundColor = Color.Gray,
                BarBackgroundColor = Color.Gray
            };
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