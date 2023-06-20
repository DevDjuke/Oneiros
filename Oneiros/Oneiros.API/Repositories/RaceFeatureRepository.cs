using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class RaceFeatureRepository : IRaceFeatureRepository
    {        
        private OneirosContext context;
        public RaceFeatureRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<RaceFeature>> GetAll()
        {            
            return await context.RaceFeatures.ToListAsync();
        }    
       
        public async Task<RaceFeature> GetById(int id)
        {
            return await context.RaceFeatures.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            RaceFeature result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(RaceFeature obj){
            context.RaceFeatures.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(RaceFeature obj)
        {
            context.RaceFeatures.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}