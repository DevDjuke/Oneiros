using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPresetSkillService: IService
    {
        public Task<IEnumerable<PresetSkillDTO>> GetAll();
        public Task<PresetSkillDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PresetSkillDTO dto);
        public Task<bool> Create(PresetSkillDTO dto);
    }
}