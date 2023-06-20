using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class PresetAbilityService : IPresetAbilityService
    {        
        private ICampaignRepository repo;
        public PresetAbilityService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<PresetAbilityDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<PresetAbilityDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PresetAbilityDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PresetAbilityDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}