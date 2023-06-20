using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class PresetLanguageRepository : IPresetLanguageRepository
    {        
        private OneirosContext context;
        public PresetLanguageRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<PresetLanguage>> GetAll()
        {            
            return await context.PresetLanguages.ToListAsync();
        }    
       
        public async Task<PresetLanguage> GetById(int id)
        {
            return await context.PresetLanguages.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            PresetLanguage result = await GetById(id);
            if (result != null){
                context.PresetLanguages.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(PresetLanguage obj){
            context.PresetLanguages.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(PresetLanguage obj)
        {
            context.PresetLanguages.Add(obj);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<PresetLanguage>> GetByNonPlayer(int id)
        {
           
                return await context.PresetLanguages.Where(x => x.NonPlayerId == id).ToListAsync();
            
        }
    }
}