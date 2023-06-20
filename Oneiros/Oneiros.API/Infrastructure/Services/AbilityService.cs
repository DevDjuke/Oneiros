using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class AbilityService : IAbilityService
    {        
        private ICampaignRepository repo;
        public AbilityService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<AbilityDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<AbilityDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(AbilityDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(AbilityDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}