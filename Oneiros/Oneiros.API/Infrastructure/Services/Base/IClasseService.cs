using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IClasseService: IService
    {
        public Task<IEnumerable<ClasseDTO>> GetAll();
        public Task<ClasseDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(ClasseDTO dto);
        public Task<bool> Create(ClasseDTO dto);
    }
}