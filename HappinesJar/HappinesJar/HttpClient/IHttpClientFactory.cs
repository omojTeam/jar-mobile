namespace HappinesJar.HttpClient
{
    public interface IHttpClientFactory
    {
        System.Net.Http.HttpClient GetHttpClient();
    }
}