using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterService : ICharacterService
    {        
        private ICampaignRepository repo;
        public CharacterService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}