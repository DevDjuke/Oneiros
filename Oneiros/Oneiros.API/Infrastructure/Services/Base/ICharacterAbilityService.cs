using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterAbilityService: IService
    {
        public Task<IEnumerable<CharacterAbilityDTO>> GetAll();
        public Task<CharacterAbilityDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterAbilityDTO dto);
        public Task<bool> Create(CharacterAbilityDTO dto);
    }
}