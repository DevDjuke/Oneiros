using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;

namespace Oneiros.Web.Services.Base
{
    public interface IPresetWebService
    {
        public Task<List<PresetSimpleDTO>> GetSimplePresetList();
    }
}
