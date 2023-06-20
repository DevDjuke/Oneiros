using Oneiros.Data.DTO;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface INonPlayerBuildRepository
    {
        Task<IEnumerable<NonPlayerBuild>> GetAll();
        Task<NonPlayerBuild> GetById(int id);
        Task Delete(int id);

        Task Update(NonPlayerBuild obj);

        Task Create(NonPlayerBuild obj);
        Task<IEnumerable<NonPlayerBuild>> GetByNonPlayer(int id);
    }
}