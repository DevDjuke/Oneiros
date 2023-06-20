using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{
        public interface IItemRepository
        {
            Task<IEnumerable<Item>> GetAll();
            Task<Item> GetById(int id);
            Task Delete(int id);

            Task Update(Item obj);

            Task Create(Item obj);
        }
    }
