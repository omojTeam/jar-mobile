using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace HappinesJar.HttpClient
{
    internal class CustomHttpClientHandler : HttpClientHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,
            CancellationToken cancellationToken)
        {
            HttpResponseMessage httpResponseMessage =
                await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
#if DEBUG
            string readAsStringAsync = await httpResponseMessage.Content.ReadAsStringAsync().ConfigureAwait(false);
#endif
            return httpResponseMessage;
        }
    }
}