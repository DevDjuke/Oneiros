using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class FeatureService : IFeatureService
    {        
        private ICampaignRepository repo;
        public FeatureService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<FeatureDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<FeatureDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(FeatureDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(FeatureDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}