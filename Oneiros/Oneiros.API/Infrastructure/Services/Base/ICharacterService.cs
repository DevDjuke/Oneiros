using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterService: IService
    {
        public Task<IEnumerable<CharacterDTO>> GetAll();
        public Task<CharacterDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterDTO dto);
        public Task<bool> Create(CharacterDTO dto);
    }
}