using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface IRaceFeatureService: IService
    {
        public Task<IEnumerable<RaceFeatureDTO>> GetAll();
        public Task<RaceFeatureDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(RaceFeatureDTO dto);
        public Task<bool> Create(RaceFeatureDTO dto);
    }
}