using Oneiros.Domain.Model;
namespace Oneiros.API.Repositories.Interfaces
{
        public interface ICharacterRepository
        {
            Task<IEnumerable<Character>> GetAll();
            Task<Character> GetById(int id);
            Task Delete(int id);

            Task Update(Character obj);

            Task Create(Character obj);
        }
    }
