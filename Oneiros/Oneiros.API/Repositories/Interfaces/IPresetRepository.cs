using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IPresetRepository
        {
            Task<IEnumerable<Preset>> GetAll();
            Task<Preset> GetById(int id);
            Task Delete(int id);

            Task Update(Preset obj);

            Task Create(Preset obj);
        }
    }
