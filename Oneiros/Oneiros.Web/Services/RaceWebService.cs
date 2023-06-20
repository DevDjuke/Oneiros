using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;
using Oneiros.Web.Services.Base;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class RaceWebService : WebService, IRaceWebService
    {
        public RaceWebService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<List<RaceDTO>> GetRaceList()
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync("race/all");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<RaceDTO>>(content);
            }

            else return null;
        }
    }
}
