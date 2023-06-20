using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface ICharacterFeatureService: IService
    {
        public Task<IEnumerable<CharacterFeatureDTO>> GetAll();
        public Task<CharacterFeatureDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(CharacterFeatureDTO dto);
        public Task<bool> Create(CharacterFeatureDTO dto);
    }
}