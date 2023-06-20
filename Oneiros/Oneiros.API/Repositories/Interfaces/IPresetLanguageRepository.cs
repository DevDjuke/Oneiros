using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;
namespace Oneiros.API.Repositories.Interfaces
{
    public interface IPresetLanguageRepository
    {
        Task<IEnumerable<PresetLanguage>> GetAll();
        Task<PresetLanguage> GetById(int id);
        Task<IEnumerable<PresetLanguage>> GetByNonPlayer(int id);
        Task Delete(int id);

        Task Update(PresetLanguage obj);

        Task Create(PresetLanguage obj);
    }
}