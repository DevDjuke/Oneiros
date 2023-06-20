namespace Oneiros.Admin.ClassTemplates
{
    public static class ServiceTemplate
    {
        public static string Template(string filename)
        {
            return
$@"using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{{
    public class {filename}Service : I{filename}Service
    {{        
        private I{filename}Repository repo;
        public {filename}Service(I{filename}Repository repo){{this.repo = repo;}}
        
        public async Task<IEnumerable<{filename}DTO>> GetAll()
        {{            
            throw new NotImplementedException();
        }}    
       
        public async Task<{filename}DTO> GetById(int id)
        {{
            throw new NotImplementedException();
        }}
        
        public async Task<bool> Delete(int id)
        {{
            throw new NotImplementedException();
        }}
        
        public async Task<bool> Update({filename}DTO obj){{
            throw new NotImplementedException();
        }}
        
        public async Task<bool> Create({filename}DTO obj)
        {{
            throw new NotImplementedException();
        }}
    }}
}}";

        }

        public static string ITemplate(string filename)
        {
            return
$@"
using Oneiros.Data.DTO;
namespace Oneiros.API.Infrastructure.Services.Base
{{
    public interface I{filename}Service: IService
    {{
        public Task<IEnumerable<{filename}DTO>> GetAll();
        public Task<{filename}DTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update({filename}DTO dto);
        public Task<bool> Create({filename}DTO dto);
    }}
}}";
        }
    }
}
