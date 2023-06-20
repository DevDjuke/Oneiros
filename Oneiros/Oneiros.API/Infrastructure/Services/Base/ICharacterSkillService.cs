using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterSkillService: IService
    {
        public Task<IEnumerable<CharacterSkillDTO>> GetAll();
        public Task<CharacterSkillDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterSkillDTO dto);
        public Task<bool> Create(CharacterSkillDTO dto);
    }
}