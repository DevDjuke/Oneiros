using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterLanguageService: IService
    {
        public Task<IEnumerable<CharacterLanguageDTO>> GetAll();
        public Task<CharacterLanguageDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterLanguageDTO dto);
        public Task<bool> Create(CharacterLanguageDTO dto);
    }
}