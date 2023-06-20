using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterFeatureRepository
        {
            Task<IEnumerable<CharacterFeature>> GetAll();
            Task<CharacterFeature> GetById(int id);
            Task Delete(int id);

            Task Update(CharacterFeature obj);

            Task Create(CharacterFeature obj);
        }
    }
