using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface IPresetSkillRepository
    {
        Task<IEnumerable<PresetSkill>> GetAll();
        Task<PresetSkill> GetById(int id);
        Task Delete(int id);

        Task Update(PresetSkill obj);

        Task Create(PresetSkill obj);
    }
}