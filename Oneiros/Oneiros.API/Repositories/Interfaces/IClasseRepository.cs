using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel.Player;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IClasseRepository
        {
            Task<IEnumerable<Classe>> GetAll();
            Task<Classe> GetById(int id);
            Task Delete(int id);

            Task Update(Classe obj);

            Task Create(Classe obj);
        }
    }
