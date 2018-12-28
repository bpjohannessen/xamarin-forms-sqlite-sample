using System;
using System.Collections.Generic;
using Alus.Helpers;
using Alus.Models;
using Xamarin.Forms;

namespace Alus.Views
{
    public partial class ProducerDetailView : ContentPage
    {
        public ProducerDetailView(int ProducerId)
        {
            InitializeComponent();

            DisplayAlert("OK", ProducerId.ToString(), "HEI");

            //List<AUser> users = AUsers.GetAll();
            List<ABeer> allbeers = ABeers.GetBeers();

            List<ABeer> beers = ABeers.GetBeerByProducerId(ProducerId);
            ListViewProducerDetail.ItemsSource = allbeers;

        }
    }
}
