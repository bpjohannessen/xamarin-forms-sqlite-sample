using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Alus.Views;
using Alus.Models;
using Alus.Helpers;
using System.Collections.Generic;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Alus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();

            //InitializeComponent();

            //MainPage = new MainPage();

            //Create some sample data
            //NLUsers.CreateSampleData();
            //List<AUser> users = AUsers.GetAll();

            // OLD
            //
            //
            //

            ////Create a list bound to the data
            //var template = new DataTemplate(typeof(TextCell));
            //template.SetBinding(TextCell.TextProperty, "UserName");

            //ListView listUsers = new ListView()
            //{
            //    //ItemsSource = users,
            //    ItemTemplate = template
            //};


            //// The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            listUsers
            //        }
            //    }
            //};
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
