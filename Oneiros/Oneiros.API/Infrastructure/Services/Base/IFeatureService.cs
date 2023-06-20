using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IFeatureService: IService
    {
        public Task<IEnumerable<FeatureDTO>> GetAll();
        public Task<FeatureDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(FeatureDTO dto);
        public Task<bool> Create(FeatureDTO dto);
    }
}