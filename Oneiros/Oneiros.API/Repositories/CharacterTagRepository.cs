using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class CharacterTagRepository : ICharacterTagRepository
    {        
        private OneirosContext context;
        public CharacterTagRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CharacterTag>> GetAll()
        {            
            return await context.CharacterTags.ToListAsync();
        }    
       
        public async Task<CharacterTag> GetById(int id)
        {
            return await context.CharacterTags.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CharacterTag result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CharacterTag obj){
            context.CharacterTags.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CharacterTag obj)
        {
            context.CharacterTags.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}