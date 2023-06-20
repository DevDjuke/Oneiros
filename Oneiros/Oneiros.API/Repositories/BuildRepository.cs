using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Repositories
{
    public class BuildRepository : IBuildRepository
    {        
        private OneirosContext context;
        public BuildRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Build>> GetAll()
        {            
            return await context.Builds.ToListAsync();
        }    
       
        public async Task<Build> GetById(int id)
        {
            return await context.Builds.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Build result = await GetById(id);
            if (result != null){
                context.Builds.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Build obj){
            context.Builds.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Build obj)
        {
            context.Builds.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}