using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class RaceRepository : IRaceRepository
    {        
        private OneirosContext context;
        public RaceRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Race>> GetAll()
        {            
            return await context.Races.ToListAsync();
        }    
       
        public async Task<Race> GetById(int id)
        {
            return await context.Races.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Race result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Race obj){
            context.Races.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Race obj)
        {
            context.Races.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}