using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ITagService: IService
    {
        public Task<IEnumerable<TagDTO>> GetAll();
        public Task<TagDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(TagDTO dto);
        public Task<bool> Create(TagDTO dto);
    }
}