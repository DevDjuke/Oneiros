using Oneiros.Data.DTO;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IRaceService: IService
    {
        public Task<IEnumerable<RaceDTO>> GetAll();
        public Task<RaceDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(RaceDTO dto);
        public Task<bool> Create(RaceDTO dto);

        public RaceDTO Map(Race obj);
    }
}