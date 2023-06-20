using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class ItemRepository : IItemRepository
    {        
        private OneirosContext context;
        public ItemRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Item>> GetAll()
        {            
            return await context.Items.ToListAsync();
        }    
       
        public async Task<Item> GetById(int id)
        {
            return await context.Items.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Item result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Item obj){
            context.Items.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Item obj)
        {
            context.Items.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}