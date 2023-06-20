using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;
using Oneiros.Web.Services.Base;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class LanguageWebService : WebService, ILanguageWebService
    {
        public LanguageWebService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<List<LanguageDTO>> GetLanguageList()
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync("language/all");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<LanguageDTO>>(content);
            }

            else return null;
        }
    }
}
