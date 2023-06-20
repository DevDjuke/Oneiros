namespace Oneiros.Admin.ClassTemplates
{
    public static class RepositoryTemplate
    {
        public static string Template(string filename)
        {
            return 
$@"using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.API.Repositories.Interfaces;

namespace Oneiros.API.Repositories
{{
    public class {filename}Repository : I{filename}Repository
    {{        
        private OneirosContext context;
        public {filename}Repository(OneirosContext context){{this.context = context;}}
        
        public async Task<IEnumerable<{filename}>> GetAll()
        {{            
            return await context.{filename}s.ToListAsync();
        }}    
       
        public async Task<{filename}> GetById(int id)
        {{
            return await context.{filename}s.FindAsync(id);
        }}
        
        public async Task Delete(int id)
        {{
            {filename} result = await GetById(id);
            if (result != null){{
                context.{filename}s.Remove(result);                
                await context.SaveChangesAsync();
            }}
        }}
        
        public async Task Update({filename} obj){{
            context.{filename}s.Update(obj);
            await context.SaveChangesAsync();
        }}
        
        public async Task Create({filename} obj)
        {{
            context.{filename}s.Add(obj);
            await context.SaveChangesAsync();
        }}
    }}
}}";
        }

        public static string ITemplate(string filename)
        {
            return
$@"using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{{
    public interface I{filename}Repository
    {{
        Task<IEnumerable<{filename}>> GetAll();
        Task<{filename}> GetById(int id);
        Task Delete(int id);

        Task Update({filename} obj);

        Task Create({filename} obj);
    }}
}}";
        }
    }
}
