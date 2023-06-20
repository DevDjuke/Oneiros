using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Repositories.Interfaces
{
        public interface IBackGroundRepository
        {
            Task<IEnumerable<BackGround>> GetAll();
            Task<BackGround> GetById(int id);
            Task Delete(int id);

            Task Update(BackGround obj);

            Task Create(BackGround obj);
        }
    }
