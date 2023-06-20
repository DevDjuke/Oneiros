using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterAbilityService : ICharacterAbilityService
    {        
        private ICampaignRepository repo;
        public CharacterAbilityService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterAbilityDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterAbilityDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterAbilityDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterAbilityDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}