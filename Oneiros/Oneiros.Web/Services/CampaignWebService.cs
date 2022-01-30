using Oneiros.Data.DTO;
using Oneiros.Infrastructure.Web;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class CampaignWebService : ICampaignWebService
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CampaignWebService(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<List<CampaignDTO>> GetAll()
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync("campaign/all");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<CampaignDTO>>(content);
            }

            else return null;
        }

    }
}
