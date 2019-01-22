using System;
using System.Collections.Generic;
using Alus.Helpers;
using Alus.Models;
using Xamarin.Forms;

namespace Alus.Views
{
    public partial class BeersView : ContentPage
    {
        public BeersView()
        {
            InitializeComponent();

            List<ABeer> allBeers = ABeers.GetBeers();

            ListViewBeers.ItemsSource = allBeers;
        }

        async void ListViewBeers_Tapped(object sender, ItemTappedEventArgs e)
        {
            ListViewBeers.SelectedItem = null;
            await Navigation.PushAsync(new BeerDetailView
            {
                BindingContext = e.Item as ABeer
            });  
        }
    }
}