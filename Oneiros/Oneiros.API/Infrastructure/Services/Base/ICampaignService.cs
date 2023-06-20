using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICampaignService: IService
    {
        public Task<IEnumerable<CampaignDTO>> GetAll();
        public Task<CampaignDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CampaignDTO dto);
        public Task<bool> Create(CampaignDTO dto);
    }
}