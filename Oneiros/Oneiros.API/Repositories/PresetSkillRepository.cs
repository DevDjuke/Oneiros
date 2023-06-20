using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class PresetSkillRepository : IPresetSkillRepository
    {        
        private OneirosContext context;
        public PresetSkillRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<PresetSkill>> GetAll()
        {            
            return await context.PresetSkills.ToListAsync();
        }    
       
        public async Task<PresetSkill> GetById(int id)
        {
            return await context.PresetSkills.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            PresetSkill result = await GetById(id);
            if (result != null){
                context.PresetSkills.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(PresetSkill obj){
            context.PresetSkills.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(PresetSkill obj)
        {
            context.PresetSkills.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}