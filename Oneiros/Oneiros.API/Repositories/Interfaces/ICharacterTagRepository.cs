using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterTagRepository
        {
            Task<IEnumerable<CharacterTag>> GetAll();
            Task<CharacterTag> GetById(int id);
            Task Delete(int id);

            Task Update(CharacterTag obj);

            Task Create(CharacterTag obj);
        }
    }
