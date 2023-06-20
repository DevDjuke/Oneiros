using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPlayerService: IService
    {
        public Task<IEnumerable<PlayerDTO>> GetAll();
        public Task<PlayerDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PlayerDTO dto);
        public Task<bool> Create(PlayerDTO dto);
    }
}