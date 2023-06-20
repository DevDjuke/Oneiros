using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class CharacterFeatureRepository : ICharacterFeatureRepository
    {        
        private OneirosContext context;
        public CharacterFeatureRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<CharacterFeature>> GetAll()
        {            
            return await context.CharacterFeatures.ToListAsync();
        }    
       
        public async Task<CharacterFeature> GetById(int id)
        {
            return await context.CharacterFeatures.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            CharacterFeature result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(CharacterFeature obj){
            context.CharacterFeatures.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(CharacterFeature obj)
        {
            context.CharacterFeatures.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}