using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class BackGroundService : IBackGroundService
    {        
        private ICampaignRepository repo;
        public BackGroundService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<BackGroundDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<BackGroundDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(BackGroundDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(BackGroundDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}