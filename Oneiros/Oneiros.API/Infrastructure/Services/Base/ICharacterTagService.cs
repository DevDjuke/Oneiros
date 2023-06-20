using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterTagService: IService
    {
        public Task<IEnumerable<CharacterTagDTO>> GetAll();
        public Task<CharacterTagDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterTagDTO dto);
        public Task<bool> Create(CharacterTagDTO dto);
    }
}