using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class CharacterSkillService : ICharacterSkillService
    {        
        private ICampaignRepository repo;
        public CharacterSkillService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<CharacterSkillDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<CharacterSkillDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(CharacterSkillDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(CharacterSkillDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}