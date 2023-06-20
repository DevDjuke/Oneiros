using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model;

namespace Oneiros.API.Infrastructure.Services
{
    public class CampaignService : ICampaignService
    {
        private ICampaignRepository campaignRepo;

        public CampaignService(
            ICampaignRepository campaignRepository)
        {
            campaignRepo = campaignRepository;
        }

        public Task<bool> Create(CampaignDTO campaign)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CampaignDTO> GetById(int id)
        {
            Campaign campaign = (await campaignRepo.GetById(id));
            CampaignDTO result = new CampaignDTO()
            {
                CampaignId = campaign.Id,
                CampaignName = campaign.Name,
                EndDate = campaign.EndDate,
                StartDate = campaign.StartDate,
                IsDone = DateTime.UtcNow > campaign.EndDate,
                //NumberOfPlayers = (await playerCampaignRepository.GetByCampaignId(id)).Count()
            };
            return result;
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
                    EndDate= campaign.EndDate,
                    StartDate = campaign.StartDate,
                    IsDone = DateTime.UtcNow > campaign.EndDate,
                    //NumberOfPlayers = (await playerCampaignRepository.GetByCampaignId(campaign.Id)).Count()
                });
            }

            return result;
        }

        public Task<bool> Update(CampaignDTO campaign)
        {
            throw new NotImplementedException();
        }
    }
}
