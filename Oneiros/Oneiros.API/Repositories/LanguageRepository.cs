using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {        
        private OneirosContext context;
        public LanguageRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Language>> GetAll()
        {            
            return await context.Languages.ToListAsync();
        }    
       
        public async Task<Language> GetById(int id)
        {
            return await context.Languages.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Language result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Language obj){
            context.Languages.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Language obj)
        {
            context.Languages.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}