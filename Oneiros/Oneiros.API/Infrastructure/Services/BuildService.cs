using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Infrastructure.Services
{
    public class BuildService : IBuildService
    {        
        private IBuildRepository repo;

        private IPresetService presetService;
        public BuildService(
            IBuildRepository repo,
            IPresetService presetService)
        {
            this.repo = repo;
            this.presetService = presetService;
        }
        
        public async Task<IEnumerable<BuildDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<BuildDTO> GetById(int id)
        {
            return await Map(await repo.GetById(id));
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(BuildDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(BuildDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<BuildDTO> Map(Build obj)
        {
            return new BuildDTO()
            {
                Id = obj.Id,
                Preset = await presetService.GetById(obj.PresetId),
            };
        }
    }
}