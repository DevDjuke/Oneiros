using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class NonPlayerRepository : INonPlayerRepository
    {        
        private OneirosContext context;
        public NonPlayerRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<NonPlayer>> GetAll()
        {   
            return await context.NPCs.ToListAsync();
        }    
       
        public async Task<NonPlayer> GetById(int id)
        {
            return await context.NPCs.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            NonPlayer result = await GetById(id);
            if (result != null){
                context.NPCs.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(NonPlayer obj){
            context.NPCs.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(NonPlayer obj)
        {
            context.NPCs.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}