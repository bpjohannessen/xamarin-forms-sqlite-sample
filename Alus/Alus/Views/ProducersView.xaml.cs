using System;
using System.Collections.Generic;
using Alus.Helpers;
using Alus.Models;
using Xamarin.Forms;

namespace Alus.Views
{
    public partial class ProducersView : ContentPage
    {
        public ProducersView()
        {
            InitializeComponent();

            List<AProducer> producers = AProducers.GetAll();
            ListViewProducers.ItemsSource = producers;
        }

        async void ListViewProducers_Tapped(object sender, ItemTappedEventArgs e)
        {
            ListViewProducers.SelectedItem = null;

            await Navigation.PushAsync(new ProducerDetailView()
            {
                BindingContext = e.Item as AProducer
            });
        }
    }
}