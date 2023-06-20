using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterLanguageService : ICharacterLanguageService
    {        
        private ICampaignRepository repo;
        public CharacterLanguageService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterLanguageDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterLanguageDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterLanguageDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterLanguageDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}