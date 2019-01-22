using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Alus.Views
{
    public partial class FirstTimeView : ContentPage
    {
        public FirstTimeView()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new MainPage()));
        }
    }
}
