using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;

namespace Oneiros.Web.Services.Base
{
    public interface ILanguageWebService
    {
        public Task<List<LanguageDTO>> GetLanguageList();
    }
}
