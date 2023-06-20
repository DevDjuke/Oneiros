using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IAbilityRepository
        {
            Task<IEnumerable<Ability>> GetAll();
            Task<Ability> GetById(int id);
            Task Delete(int id);

            Task Update(Ability obj);

            Task Create(Ability obj);
        }
}