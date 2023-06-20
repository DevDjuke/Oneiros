
using Oneiros.Data.DTO;
namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IBuildService: IService
    {
        public Task<IEnumerable<BuildDTO>> GetAll();
        public Task<BuildDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(BuildDTO dto);
        public Task<bool> Create(BuildDTO dto);
    }
}