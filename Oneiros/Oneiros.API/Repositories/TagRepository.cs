using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Generic;

namespace Oneiros.API.Repositories
{
    public class TagRepository : ITagRepository
    {        
        private OneirosContext context;
        public TagRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Tag>> GetAll()
        {            
            return await context.Tags.ToListAsync();
        }    
       
        public async Task<Tag> GetById(int id)
        {
            return await context.Tags.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Tag result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Tag obj){
            context.Tags.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Tag obj)
        {
            context.Tags.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}