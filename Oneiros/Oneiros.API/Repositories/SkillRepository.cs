using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class SkillRepository : ISkillRepository
    {        
        private OneirosContext context;
        public SkillRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Skill>> GetAll()
        {            
            return await context.Skills.ToListAsync();
        }    
       
        public async Task<Skill> GetById(int id)
        {
            return await context.Skills.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Skill result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Skill obj){
            context.Skills.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Skill obj)
        {
            context.Skills.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}