using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class CampaignCharacterRepository : ICampaignCharacterRepository
    {        
        private OneirosContext context;
        public CampaignCharacterRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CampaignCharacter>> GetAll()
        {            
            return await context.CampaignCharacters.ToListAsync();
        }    
       
        public async Task<CampaignCharacter> GetById(int id)
        {
            return await context.CampaignCharacters.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CampaignCharacter result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CampaignCharacter obj){
            context.CampaignCharacters.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CampaignCharacter obj)
        {
            context.CampaignCharacters.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}