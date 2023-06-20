using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterFeatureService : ICharacterFeatureService
    {        
        private ICampaignRepository repo;
        public CharacterFeatureService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterFeatureDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterFeatureDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterFeatureDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterFeatureDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}