﻿using HappinesJar.Helpers;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace HappinesJar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new HelloPage();
        }

        protected override void OnStart()
        {
            AppCenter.Start(Secrets.AppCenter,
                   typeof(Analytics), typeof(Crashes));

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