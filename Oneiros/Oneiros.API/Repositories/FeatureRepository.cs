using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class FeatureRepository : IFeatureRepository
    {        
        private OneirosContext context;
        public FeatureRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Feature>> GetAll()
        {            
            return await context.Features.ToListAsync();
        }    
       
        public async Task<Feature> GetById(int id)
        {
            return await context.Features.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Feature result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Feature obj){
            context.Features.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Feature obj)
        {
            context.Features.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}