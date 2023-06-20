using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IRaceRepository
        {
            Task<IEnumerable<Race>> GetAll();
            Task<Race> GetById(int id);
            Task Delete(int id);

            Task Update(Race obj);

            Task Create(Race obj);
        }
    }
