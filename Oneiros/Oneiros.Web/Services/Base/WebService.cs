using System.Net.Http;

namespace Oneiros.Web.Services.Base
{
    public class WebService
    {
        internal readonly IHttpClientFactory _httpClientFactory;
        public WebService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
    }
}
