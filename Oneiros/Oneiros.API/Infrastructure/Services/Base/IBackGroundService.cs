using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IBackGroundService: IService
    {
        public Task<IEnumerable<BackGroundDTO>> GetAll();
        public Task<BackGroundDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(BackGroundDTO dto);
        public Task<bool> Create(BackGroundDTO dto);
    }
}