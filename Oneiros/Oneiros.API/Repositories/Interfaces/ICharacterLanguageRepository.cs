using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterLanguageRepository
        {
            Task<IEnumerable<CharacterLanguage>> GetAll();
            Task<CharacterLanguage> GetById(int id);
            Task Delete(int id);

            Task Update(CharacterLanguage obj);

            Task Create(CharacterLanguage obj);
        }
    }
