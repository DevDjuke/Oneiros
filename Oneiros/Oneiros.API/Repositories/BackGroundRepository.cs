using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories
{
    public class BackGroundRepository : IBackGroundRepository
    {        
        private OneirosContext context;
        public BackGroundRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<BackGround>> GetAll()
        {            
            return await context.BackGrounds.ToListAsync();
        }    
       
        public async Task<BackGround> GetById(int id)
        {
            return await context.BackGrounds.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            BackGround result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(BackGround obj){
            context.BackGrounds.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(BackGround obj)
        {
            context.BackGrounds.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}