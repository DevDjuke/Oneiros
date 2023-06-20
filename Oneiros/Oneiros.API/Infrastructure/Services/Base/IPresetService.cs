using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPresetService: IService
    {
        public Task<IEnumerable<PresetDTO>> GetAll();
        public Task<PresetDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PresetDTO dto);
        public Task<bool> Create(PresetDTO dto);
    }
}