using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories
{
    public class NonPlayerBuildRepository : INonPlayerBuildRepository
    {        
        private OneirosContext context;
        public NonPlayerBuildRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<NonPlayerBuild>> GetAll()
        {            
            return await context.NonPlayerBuilds.ToListAsync();
        }    
       
        public async Task<NonPlayerBuild> GetById(int id)
        {
            return await context.NonPlayerBuilds.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            NonPlayerBuild result = await GetById(id);
            if (result != null){
                context.NonPlayerBuilds.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(NonPlayerBuild obj){
            context.NonPlayerBuilds.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(NonPlayerBuild obj)
        {
            context.NonPlayerBuilds.Add(obj);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<NonPlayerBuild>> GetByNonPlayer(int id)
        {
                return await context.NonPlayerBuilds.Where(x => x.NonPlayerId == id).ToListAsync();
        }
    }
}