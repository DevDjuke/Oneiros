using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;

namespace Oneiros.API.Infrastructure.Services
{
    public class PresetService : IPresetService
    {        
        private IPresetRepository repo;

        private IClasseService classeService;
        public PresetService(
            IPresetRepository repo,
            IClasseService classeService
            )
        {
            this.repo = repo;
            this.classeService= classeService;
        }
        
        public async Task<IEnumerable<PresetDTO>> GetAll()
        {
            List<Preset> result = (await repo.GetAll()).ToList();
            List<PresetDTO> dtoList = new List<PresetDTO>();

            foreach (var obj in result)
            {
                PresetDTO dto = await Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }    
       
        public async Task<PresetDTO> GetById(int id)
        {
            return await Map(await repo.GetById(id));
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PresetDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PresetDTO obj)
        {
            throw new NotImplementedException();
        }

        private async Task<PresetDTO> Map(Preset obj)
        {
            return new PresetDTO()
            {
                Id = obj.Id,
                Name = obj.Name,
                Description = obj.Description,
                BaseClass = await classeService.GetById(obj.BaseClassId),
            };
        }
    }
}