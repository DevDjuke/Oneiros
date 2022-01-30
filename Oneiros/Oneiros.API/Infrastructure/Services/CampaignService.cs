using Oneiros.Data.DTO;
using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories.Interfaces;
using Oneiros.Infrastructure.Services;

namespace Oneiros.API.Infrastructure.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository campaignRepo;

        public CampaignService(ICampaignRepository campaignRepository)
        {
            campaignRepo = campaignRepository;
        }

        public async Task<IEnumerable<CampaignDTO>> GetAll()
        {
            List<CampaignDTO> result = new List<CampaignDTO>();

            List<Campaign> campaigns = (await campaignRepo.GetAll()).ToList();

            foreach (var campaign in campaigns)
            {
                result.Add(new CampaignDTO()
                {
                    CampaignId = campaign.Id,
                    CampaignName = campaign.Name,
                    IsDone = DateTime.UtcNow < campaign.EndDate
                });
            }

            return result;
        }
    }
}
