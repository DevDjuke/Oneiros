using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPresetFeatureService: IService
    {
        public Task<IEnumerable<PresetFeatureDTO>> GetAll();
        public Task<PresetFeatureDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PresetFeatureDTO dto);
        public Task<bool> Create(PresetFeatureDTO dto);
    }
}