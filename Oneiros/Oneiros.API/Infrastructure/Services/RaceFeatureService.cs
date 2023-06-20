using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class RaceFeatureService : IRaceFeatureService
    {        
        private ICampaignRepository repo;
        public RaceFeatureService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<RaceFeatureDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<RaceFeatureDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(RaceFeatureDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(RaceFeatureDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}