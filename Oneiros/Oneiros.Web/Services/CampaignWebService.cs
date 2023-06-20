using Oneiros.Data.DTO;
using Oneiros.Web.Services.Base;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class CampaignWebService : WebService, ICampaignWebService
    {
        public CampaignWebService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

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

        public async Task<CampaignDTO> GetById(int id)
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync($"campaign/detail/{id}");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<CampaignDTO>(content);
            }

            else return null;
        }
    }
}
