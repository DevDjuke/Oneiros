using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterSkillRepository
        {
            Task<IEnumerable<CharacterSkill>> GetAll();
            Task<CharacterSkill> GetById(int id);
            Task Delete(int id);

            Task Update(CharacterSkill obj);

            Task Create(CharacterSkill obj);
        }
    }
