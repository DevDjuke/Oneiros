using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ISkillService: IService
    {
        public Task<IEnumerable<SkillDTO>> GetAll();
        public Task<SkillDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(SkillDTO dto);
        public Task<bool> Create(SkillDTO dto);
    }
}