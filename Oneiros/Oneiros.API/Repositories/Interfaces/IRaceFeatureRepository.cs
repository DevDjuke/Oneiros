using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IRaceFeatureRepository
        {
            Task<IEnumerable<RaceFeature>> GetAll();
            Task<RaceFeature> GetById(int id);
            Task Delete(int id);

            Task Update(RaceFeature obj);

            Task Create(RaceFeature obj);
        }
    }
