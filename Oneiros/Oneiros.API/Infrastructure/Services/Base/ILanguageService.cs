using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ILanguageService: IService
    {
        public Task<IEnumerable<LanguageDTO>> GetAll();
        public Task<LanguageDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(LanguageDTO dto);
        public Task<bool> Create(LanguageDTO dto);
    }
}