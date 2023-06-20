using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;

namespace Oneiros.API.Repositories
{
    public class CharacterRepository : ICharacterRepository
    {        
        private OneirosContext context;
        public CharacterRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Character>> GetAll()
        {            
            return await context.Characters.ToListAsync();
        }    
       
        public async Task<Character> GetById(int id)
        {
            return await context.Characters.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Character result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Character obj){
            context.Characters.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Character obj)
        {
            context.Characters.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}