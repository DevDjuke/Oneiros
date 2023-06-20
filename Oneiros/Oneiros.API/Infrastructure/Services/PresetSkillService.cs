using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class PresetSkillService : IPresetSkillService
    {        
        private ICampaignRepository repo;
        public PresetSkillService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<PresetSkillDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<PresetSkillDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PresetSkillDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PresetSkillDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}