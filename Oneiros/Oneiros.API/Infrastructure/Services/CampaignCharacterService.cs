using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CampaignCharacterService : ICampaignCharacterService
    {        
        private ICampaignRepository repo;
        public CampaignCharacterService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CampaignCharacterDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CampaignCharacterDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CampaignCharacterDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CampaignCharacterDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}