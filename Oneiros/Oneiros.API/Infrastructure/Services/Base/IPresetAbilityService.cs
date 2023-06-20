using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPresetAbilityService: IService
    {
        public Task<IEnumerable<PresetAbilityDTO>> GetAll();
        public Task<PresetAbilityDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PresetAbilityDTO dto);
        public Task<bool> Create(PresetAbilityDTO dto);
    }
}