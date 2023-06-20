using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel.Player;

namespace Oneiros.API.Repositories
{
    public class ClasseRepository : IClasseRepository
    {        
        private OneirosContext context;
        public ClasseRepository(OneirosContext context){this.context = context;}
        
        public async Task<IEnumerable<Classe>> GetAll()
        {            
            return await context.Classes.ToListAsync();
        }    
       
        public async Task<Classe> GetById(int id)
        {
            return await context.Classes.FindAsync(id);
        }
        
        public async Task Delete(int id)
        {
            Classe result = await GetById(id);
            if (result != null){
                context.Remove(result);                
                await context.SaveChangesAsync();
            }
        }
        
        public async Task Update(Classe obj){
            context.Classes.Update(obj);
            await context.SaveChangesAsync();
        }
        
        public async Task Create(Classe obj)
        {
            context.Classes.Add(obj);
            await context.SaveChangesAsync();
        }
    }
}