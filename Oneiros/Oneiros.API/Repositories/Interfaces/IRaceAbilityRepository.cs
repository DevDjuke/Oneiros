using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IRaceAbilityRepository
        {
            Task<IEnumerable<RaceAbility>> GetAll();
            Task<RaceAbility> GetById(int id);
            Task Delete(int id);

            Task Update(RaceAbility obj);

            Task Create(RaceAbility obj);
        }
    }
