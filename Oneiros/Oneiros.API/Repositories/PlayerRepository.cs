using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {        
        private OneirosContext context;
        public PlayerRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Player>> GetAll()
        {            
            return await context.Players.ToListAsync();
        }    
       
        public async Task<Player> GetById(int id)
        {
            return await context.Players.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Player result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Player obj){
            context.Players.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Player obj)
        {
            context.Players.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}