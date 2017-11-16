using System;
using System.Collections.Generic;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;
using Xamarin.Forms;

namespace MobileCenterTest.Views
{
    public partial class TopView : ContentPage
    {
        public TopView()
        {
            InitializeComponent();
        }

        void ShowView1(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> {{ "View", "1  " }});
            Navigation.PushAsync(new View1(), true);
        }

        void ShowView2(object sender, System.EventArgs e)
        {
            Device.OpenUri(new Uri("http://xamarin.com/evolve"));
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "2" } });
            Navigation.PushAsync(new View2(), true);
        }

        void ShowView3(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "3" } });
            Navigation.PushAsync(new View3(), true);
        }

        void ShowView4(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "4" } });
            Navigation.PushAsync(new View4(), true);
        }

        void ShowView5(object sender, System.EventArgs e)
        {
            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "5" } });
            Navigation.PushAsync(new View5(), true);
        }

        void ShowView6(object sender, System.EventArgs e)
        {
            //クラッシュする
            Crashes.GenerateTestCrash();

            Analytics.TrackEvent("View", new Dictionary<string, string> { { "View", "6" } });
            Navigation.PushAsync(new View6(), true);
        }
    }
}
