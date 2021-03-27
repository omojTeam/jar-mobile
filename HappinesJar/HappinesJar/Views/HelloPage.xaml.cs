using HappinesJar.HttpClient;
using HappinesJar.Services.Cards;
using Microsoft.AppCenter.Crashes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HappinesJar
{
    public partial class HelloPage : ContentPage
    {
        public HelloPage()
        {
            InitializeComponent();


            //HttpClientFactory httpClientFactory = new HttpClientFactory();
            //var service = Refit.RestService.For<ICardService>(httpClientFactory.GetHttpClient());
            //Task.Run(async () =>
            //{
            //    try
            //    {
            //        var result = await service.GetJarAsync();
            //    }
            //    catch (Exception ex)
            //    {
            //        Crashes.TrackError(ex);

            //    }
            //});
        }
    }
}