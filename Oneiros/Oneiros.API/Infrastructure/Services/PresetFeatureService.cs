using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class PresetFeatureService : IPresetFeatureService
    {        
        private ICampaignRepository repo;
        public PresetFeatureService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<PresetFeatureDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<PresetFeatureDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PresetFeatureDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PresetFeatureDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}