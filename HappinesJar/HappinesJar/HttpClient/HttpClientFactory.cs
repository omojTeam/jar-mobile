using HappinesJar.Helpers;
using System;

namespace HappinesJar.HttpClient
{
    public class HttpClientFactory : IHttpClientFactory
    {
        private readonly string _path;

        public HttpClientFactory()
        {
            _path = Secrets.ApiPath;

        }

        public System.Net.Http.HttpClient GetHttpClient()
        {
            CustomHttpClientHandler httpClientHandler = new CustomHttpClientHandler();
            System.Net.Http.HttpClient httpClient = new System.Net.Http.HttpClient(httpClientHandler)
            {
                BaseAddress = new Uri(_path)
            };
            return httpClient;
        }

        public string Token { get; set; } = "Token from Agrico mobile app";
    }
}