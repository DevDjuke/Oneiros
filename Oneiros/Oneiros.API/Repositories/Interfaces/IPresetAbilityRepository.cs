using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface IPresetAbilityRepository
    {
        Task<IEnumerable<PresetAbility>> GetAll();
        Task<PresetAbility> GetById(int id);
        Task Delete(int id);

        Task Update(PresetAbility obj);

        Task Create(PresetAbility obj);
    }
}