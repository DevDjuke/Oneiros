using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Infrastructure.Services
{
    public class NonPlayerBuildService : INonPlayerBuildService
    {        
        private INonPlayerBuildRepository repo;
        public NonPlayerBuildService(INonPlayerBuildRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<NonPlayerBuildDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<NonPlayerBuildDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(NonPlayerBuildDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(NonPlayerBuildDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<NonPlayerBuildDTO> Map(NonPlayerBuild dto)
        {
            return new NonPlayerBuildDTO()
            {
                Id = dto.Id,
                BuildId = dto.BuildId,
                NonPlayerId = dto.NonPlayerId,
            };
        }

        public async Task<IEnumerable<NonPlayerBuildDTO>> GetByNonPlayer(int id)
        {
            List<NonPlayerBuild> result = (await repo.GetByNonPlayer(id)).ToList();
            List<NonPlayerBuildDTO> dtoList = new List<NonPlayerBuildDTO>();

            foreach (var obj in result)
            {
                NonPlayerBuildDTO dto = await Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}