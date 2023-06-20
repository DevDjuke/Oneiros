using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ILanguageRepository
        {
            Task<IEnumerable<Language>> GetAll();
            Task<Language> GetById(int id);
            Task Delete(int id);

            Task Update(Language obj);

            Task Create(Language obj);
        }
    }
