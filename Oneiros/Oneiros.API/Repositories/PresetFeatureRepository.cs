using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class PresetFeatureRepository : IPresetFeatureRepository
    {        
        private OneirosContext context;
        public PresetFeatureRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<PresetFeature>> GetAll()
        {            
            return await context.PresetFeatures.ToListAsync();
        }    
       
        public async Task<PresetFeature> GetById(int id)
        {
            return await context.PresetFeatures.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            PresetFeature result = await GetById(id);
            if (result != null){
                context.PresetFeatures.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(PresetFeature obj){
            context.PresetFeatures.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(PresetFeature obj)
        {
            context.PresetFeatures.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}