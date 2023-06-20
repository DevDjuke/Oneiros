using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IItemService: IService
    {
        public Task<IEnumerable<ItemDTO>> GetAll();
        public Task<ItemDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(ItemDTO dto);
        public Task<bool> Create(ItemDTO dto);
    }
}