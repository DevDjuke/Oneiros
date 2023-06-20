using Oneiros.Data.DTO;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IPresetLanguageService: IService
    {
        public Task<IEnumerable<PresetLanguageDTO>> GetAll();
        public Task<IEnumerable<PresetLanguageDTO>> GetByNonPlayer(int id);
        public Task<PresetLanguageDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(PresetLanguageDTO dto);
        public Task<bool> Create(PresetLanguageDTO dto);

        public Task<PresetLanguageDTO> Map(PresetLanguage obj);
    }
}