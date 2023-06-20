using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class PlayerService : IPlayerService
    {        
        private ICampaignRepository repo;
        public PlayerService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<PlayerDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<PlayerDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PlayerDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PlayerDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}