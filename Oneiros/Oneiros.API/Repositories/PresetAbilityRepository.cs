using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class PresetAbilityRepository : IPresetAbilityRepository
    {        
        private OneirosContext context;
        public PresetAbilityRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<PresetAbility>> GetAll()
        {            
            return await context.PresetAbilities.ToListAsync();
        }    
       
        public async Task<PresetAbility> GetById(int id)
        {
            return await context.PresetAbilities.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            PresetAbility result = await GetById(id);
            if (result != null){
                context.PresetAbilities.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(PresetAbility obj){
            context.PresetAbilities.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(PresetAbility obj)
        {
            context.PresetAbilities.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}