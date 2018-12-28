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

            AProducer TappedProducer = e.Item as AProducer;

            if (TappedProducer == null) return;
            int teste = TappedProducer.ProducerId;

            await this.Navigation.PushAsync(new ProducerDetailView(TappedProducer.ProducerId)
            {
                //BindingContext = e.Item as ABeer
            });
            //await Navigation.PushAsync(new ProducerDetailView
            //{
            //    BindingContext = e.Item as AProducer
            //});

            //
            //int id = item.BeerId;
            //string BeerName = item.BeerName;

            //var SelectedBeer = e.Item as ABeer;
            //var BId = SelectedBeer.BeerId;
            //var stId = BId.ToString();
            
            //ListViewProducers.SelectedItem = null;
            //await DisplayAlert("OK", Convert.ToString(SelectedBeer.BeerId), "OK");
            ////await Navigation.PushAsync(new ProducerDetailView(SelectedBeer.BeerId));
        }
    }
}

//async void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
//{
    //Fabric tappedFabric = e.Item as Fabric;

    //if (tappedFabric == null)
    //    return;

    //await this.Navigation.PushModalAsync(new ItemDetailsPage(tappedFabric));
