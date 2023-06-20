using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class CharacterAbilityRepository : ICharacterAbilityRepository
    {        
        private OneirosContext context;
        public CharacterAbilityRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CharacterAbility>> GetAll()
        {            
            return await context.CharacterAbilities.ToListAsync();
        }    
       
        public async Task<CharacterAbility> GetById(int id)
        {
            return await context.CharacterAbilities.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CharacterAbility result = await GetById(id);
            if (result != null){
                context.CharacterAbilities.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CharacterAbility obj){
            context.CharacterAbilities.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CharacterAbility obj)
        {
            context.CharacterAbilities.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}