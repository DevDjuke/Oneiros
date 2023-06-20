using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{
        public interface INonPlayerRepository
        {
            public Task<IEnumerable<NonPlayer>> GetAll();
            Task<NonPlayer> GetById(int id);
            Task Delete(int id);

            Task Update(NonPlayer obj);

            Task Create(NonPlayer obj);
        }
    }
