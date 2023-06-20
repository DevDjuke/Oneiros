using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;

namespace Oneiros.Web.Services.Base
{
    public interface INPCWebService
    {
        public Task<List<NPCSimpleDTO>> GetNPCList();
    }
}
