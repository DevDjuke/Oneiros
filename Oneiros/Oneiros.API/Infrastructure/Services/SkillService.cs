using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class SkillService : ISkillService
    {        
        private ICampaignRepository repo;
        public SkillService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<SkillDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<SkillDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(SkillDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(SkillDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}