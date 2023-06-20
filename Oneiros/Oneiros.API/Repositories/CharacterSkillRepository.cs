using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class CharacterSkillRepository : ICharacterSkillRepository
    {        
        private OneirosContext context;
        public CharacterSkillRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CharacterSkill>> GetAll()
        {            
            return await context.CharacterSkills.ToListAsync();
        }    
       
        public async Task<CharacterSkill> GetById(int id)
        {
            return await context.CharacterSkills.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CharacterSkill result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CharacterSkill obj){
            context.CharacterSkills.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CharacterSkill obj)
        {
            context.CharacterSkills.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}