using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class CharacterLanguageRepository : ICharacterLanguageRepository
    {        
        private OneirosContext context;
        public CharacterLanguageRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CharacterLanguage>> GetAll()
        {            
            return await context.CharacterLanguages.ToListAsync();
        }    
       
        public async Task<CharacterLanguage> GetById(int id)
        {
            return await context.CharacterLanguages.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CharacterLanguage result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CharacterLanguage obj){
            context.CharacterLanguages.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CharacterLanguage obj)
        {
            context.CharacterLanguages.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}