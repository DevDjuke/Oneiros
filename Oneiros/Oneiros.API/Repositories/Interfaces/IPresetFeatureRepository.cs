using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface IPresetFeatureRepository
    {
        Task<IEnumerable<PresetFeature>> GetAll();
        Task<PresetFeature> GetById(int id);
        Task Delete(int id);

        Task Update(PresetFeature obj);

        Task Create(PresetFeature obj);
    }
}