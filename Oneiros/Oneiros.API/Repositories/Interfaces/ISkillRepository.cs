using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ISkillRepository
        {
            Task<IEnumerable<Skill>> GetAll();
            Task<Skill> GetById(int id);
            Task Delete(int id);

            Task Update(Skill obj);

            Task Create(Skill obj);
        }
    }
