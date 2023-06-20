using Oneiros.Data.DTO;
namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IAbilityService: IService
    {
        public Task<IEnumerable<AbilityDTO>> GetAll();
        public Task<AbilityDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(AbilityDTO dto);
        public Task<bool> Create(AbilityDTO dto);
    }
}