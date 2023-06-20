using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Repositories.Interfaces
{
    public interface IBuildRepository
    {
        Task<IEnumerable<Build>> GetAll();
        Task<Build> GetById(int id);
        Task Delete(int id);

        Task Update(Build obj);

        Task Create(Build obj);
    }
}