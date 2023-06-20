using Oneiros.Data.DTO;
using Oneiros.Data.DTO.Derived;

namespace Oneiros.Web.Services.Base
{
    public interface IRaceWebService
    {
        public Task<List<RaceDTO>> GetRaceList();
    }
}
