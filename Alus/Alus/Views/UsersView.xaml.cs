using System;
using System.Collections.Generic;
using Alus.Helpers;
using Alus.Models;
using Xamarin.Forms;

namespace Alus.Views
{
    public partial class UsersView : ContentPage
    {
        public UsersView()
        {
            InitializeComponent();

            List<AUser> users = AUsers.GetAll();

            ListViewUsers.ItemsSource = users;
        }

        async void ListViewUsers_Tapped(object sender, ItemTappedEventArgs e)
        {
            ListViewUsers.SelectedItem = null;
            await Navigation.PushAsync(new UserDetailView
            {
                BindingContext = e.Item as AUser
            });
        }
    }
}