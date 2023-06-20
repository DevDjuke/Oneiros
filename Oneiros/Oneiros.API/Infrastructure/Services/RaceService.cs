using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.CharacterModel;

namespace Oneiros.API.Infrastructure.Services
{
    public class RaceService : IRaceService
    {        
        private IRaceRepository repo;
        public RaceService(IRaceRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<RaceDTO>> GetAll()
        {
            List<Race> result = (await repo.GetAll()).ToList();
            List<RaceDTO> dtoList = new List<RaceDTO>();

            foreach (var obj in result)
            {
                RaceDTO dto = Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }    
       
        public async Task<RaceDTO> GetById(int id)
        {
            return Map(await repo.GetById(id));
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(RaceDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(RaceDTO obj)
        {
            throw new NotImplementedException();
        }

        public RaceDTO Map(Race obj)
        {
            return new RaceDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
            };
        }
    }
}