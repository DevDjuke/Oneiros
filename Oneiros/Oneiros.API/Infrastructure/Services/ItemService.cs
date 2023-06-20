using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class ItemService : IItemService
    {        
        private ICampaignRepository repo;
        public ItemService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<ItemDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<ItemDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(ItemDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(ItemDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}