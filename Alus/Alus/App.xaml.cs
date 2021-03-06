﻿using System;
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
        public string IsFirstTime
        {
            get { return Settings.GeneralSettings; }
            set
            {
                if (Settings.GeneralSettings == value) return;
                Settings.GeneralSettings = value;
                OnPropertyChanged();
            }
        }

        public App()
        {
            InitializeComponent();

            if(IsFirstTime == "yes")
            {
                IsFirstTime = "no";
                MainPage = new FirstTimeView();
            }
            else
            {
                MainPage = new MainPage();
            }
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
