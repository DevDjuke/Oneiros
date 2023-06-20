using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Repositories
{
    public class PresetRepository : IPresetRepository
    {        
        private OneirosContext context;
        public PresetRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Preset>> GetAll()
        {            
            return await context.Presets.ToListAsync();
        }    
       
        public async Task<Preset> GetById(int id)
        {
            return await context.Presets.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Preset result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Preset obj){
            context.Presets.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Preset obj)
        {
            context.Presets.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}