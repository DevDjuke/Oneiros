using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICampaignCharacterService: IService
    {
        public Task<IEnumerable<CampaignCharacterDTO>> GetAll();
        public Task<CampaignCharacterDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CampaignCharacterDTO dto);
        public Task<bool> Create(CampaignCharacterDTO dto);
    }
}