using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class RaceAbilityService : IRaceAbilityService
    {        
        private ICampaignRepository repo;
        public RaceAbilityService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<RaceAbilityDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<RaceAbilityDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(RaceAbilityDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(RaceAbilityDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}