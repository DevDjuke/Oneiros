using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class AbilityRepository : IAbilityRepository
    {        
        private OneirosContext context;
        public AbilityRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Ability>> GetAll()
        {            
            return await context.Abilities.ToListAsync();
        }    
       
        public async Task<Ability> GetById(int id)
        {
            return await context.Abilities.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Ability result = await GetById(id);
            if (result != null){
                context.Abilities.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Ability obj){
            context.Abilities.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Ability obj)
        {
            context.Abilities.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}