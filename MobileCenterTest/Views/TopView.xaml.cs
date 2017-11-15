using System;
using System.Collections.Generic;

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
            Navigation.PushAsync(new View1(), true);
        }

        void ShowView2(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View2(), true);
        }

        void ShowView3(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View3(), true);
        }

        void ShowView4(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View4(), true);
        }

        void ShowView5(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View5(), true);
        }

        void ShowView6(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new View6(), true);
        }
    }
}
