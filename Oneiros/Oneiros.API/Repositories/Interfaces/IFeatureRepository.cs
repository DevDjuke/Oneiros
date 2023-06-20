using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IFeatureRepository
        {
            Task<IEnumerable<Feature>> GetAll();
            Task<Feature> GetById(int id);
            Task Delete(int id);

            Task Update(Feature obj);

            Task Create(Feature obj);
        }
    }
