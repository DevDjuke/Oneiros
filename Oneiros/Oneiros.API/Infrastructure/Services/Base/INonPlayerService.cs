using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface INonPlayerService: IService
    {
        public Task<IEnumerable<NonPlayerDTO>> GetAll();
        public Task<NonPlayerDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(NonPlayerDTO dto);
        public Task<bool> Create(NonPlayerDTO dto);
    }
}