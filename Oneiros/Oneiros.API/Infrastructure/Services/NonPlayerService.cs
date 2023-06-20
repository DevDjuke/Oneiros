using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model;

namespace Oneiros.API.Infrastructure.Services
{
    public class NonPlayerService : INonPlayerService
    {        
        private INonPlayerRepository repo;

        private INonPlayerBuildService nonPlayerBuildService;
        private IRaceService raceService;
        private IPresetLanguageService presetLanguageService;

        public NonPlayerService(
            INonPlayerRepository repo,
            INonPlayerBuildService nonPlayerBuildService,
            IRaceService raceService,
            IPresetLanguageService presetLanguageService)
        {
                this.repo = repo;
                this.nonPlayerBuildService = nonPlayerBuildService;
                this.raceService = raceService;
                this.presetLanguageService = presetLanguageService;
        }
        
        public async Task<IEnumerable<NonPlayerDTO>> GetAll()
        {
            List<NonPlayer> result = (await repo.GetAll()).ToList();
            List<NonPlayerDTO> dtoList = new List<NonPlayerDTO>();

            foreach (var obj in result)
            {
                NonPlayerDTO dto = await Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }

        public async Task<NonPlayerDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(NonPlayerDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(NonPlayerDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<NonPlayerDTO> Map(NonPlayer obj)
        {
            return new NonPlayerDTO()
            {
                Builds = (await nonPlayerBuildService.GetByNonPlayer(obj.Id)).ToList(),
                Id= obj.Id,
                Name= obj.Name,
                Race = await raceService.GetById(obj.RaceId),
                Languages = (await presetLanguageService.GetByNonPlayer(obj.Id)).ToList()
            };
        }
    }
}