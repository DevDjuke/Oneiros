using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class RaceAbilityRepository : IRaceAbilityRepository
    {        
        private OneirosContext context;
        public RaceAbilityRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<RaceAbility>> GetAll()
        {            
            return await context.RaceAbilities.ToListAsync();
        }    
       
        public async Task<RaceAbility> GetById(int id)
        {
            return await context.RaceAbilities.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            RaceAbility result = await GetById(id);
            if (result != null){
                context.RaceAbilities.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(RaceAbility obj){
            context.RaceAbilities.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(RaceAbility obj)
        {
            context.RaceAbilities.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}