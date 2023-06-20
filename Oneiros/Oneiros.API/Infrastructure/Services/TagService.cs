using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class TagService : ITagService
    {        
        private ICampaignRepository repo;
        public TagService(ICampaignRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<TagDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<TagDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(TagDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(TagDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}