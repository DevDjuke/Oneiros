using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;
using Oneiros.Web.Services.Base;
using System.Text.Json;

namespace Oneiros.Web.Services
{
    public class NPCWebService : WebService, INPCWebService
    {
        public NPCWebService(IHttpClientFactory httpClientFactory) : base(httpClientFactory) { }

        public async Task<List<NPCSimpleDTO>> GetNPCList()
        {
            var httpClient = _httpClientFactory.CreateClient("API");

            var httpResponseMessage = await httpClient.GetAsync("npc/list");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = await httpResponseMessage.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<NPCSimpleDTO>>(content);
            }

            else return null;
        }
    }
}
