using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterTagService : ICharacterTagService
    {        
        private ICampaignRepository repo;
        public CharacterTagService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterTagDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterTagDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterTagDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterTagDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}