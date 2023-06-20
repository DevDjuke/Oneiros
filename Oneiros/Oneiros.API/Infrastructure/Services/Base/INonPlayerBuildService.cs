
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Infrastructure.Services.Base
{
    public interface INonPlayerBuildService: IService
    {
        public Task<IEnumerable<NonPlayerBuildDTO>> GetAll();
        public Task<IEnumerable<NonPlayerBuildDTO>> GetByNonPlayer(int id);
        public Task<NonPlayerBuildDTO> GetById(int id);
        public Task<bool> Delete(int id);
        public Task<bool> Update(NonPlayerBuildDTO dto);
        public Task<bool> Create(NonPlayerBuildDTO dto);

        public Task<NonPlayerBuildDTO> Map(NonPlayerBuild dto);
    }
}