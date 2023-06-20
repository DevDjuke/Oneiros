using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;
using Oneiros.Web.Services.Base;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class PresetWebService : WebService, IPresetWebService
    {
        public PresetWebService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
        }

        public async Task<List<PresetSimpleDTO>> GetSimplePresetList()
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync("preset/list");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<PresetSimpleDTO>>(content);
            }

            else return null;
        }
    }
}
