using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IRaceAbilityService: IService
    {
        public Task<IEnumerable<RaceAbilityDTO>> GetAll();
        public Task<RaceAbilityDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(RaceAbilityDTO dto);
        public Task<bool> Create(RaceAbilityDTO dto);
    }
}