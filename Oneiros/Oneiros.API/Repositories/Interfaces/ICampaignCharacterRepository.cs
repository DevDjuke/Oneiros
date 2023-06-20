using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICampaignCharacterRepository
        {
            Task<IEnumerable<CampaignCharacter>> GetAll();
            Task<CampaignCharacter> GetById(int id);
            Task Delete(int id);

            Task Update(CampaignCharacter obj);

            Task Create(CampaignCharacter obj);
        }
    }
