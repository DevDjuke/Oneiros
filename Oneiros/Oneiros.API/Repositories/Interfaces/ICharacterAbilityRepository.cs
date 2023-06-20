using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterAbilityRepository
        {
            Task<IEnumerable<CharacterAbility>> GetAll();
            Task<CharacterAbility> GetById(int id);
            Task Delete(int id);

            Task Update(CharacterAbility obj);

            Task Create(CharacterAbility obj);
        
    }
}