using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{
        public interface IPlayerRepository
        {
            Task<IEnumerable<Player>> GetAll();
            Task<Player> GetById(int id);
            Task Delete(int id);

            Task Update(Player obj);

            Task Create(Player obj);
        }
    }
