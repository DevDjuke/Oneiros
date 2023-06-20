using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.Links;

namespace Oneiros.API.Infrastructure.Services
{
    public class PresetLanguageService : IPresetLanguageService
    {        
        private IPresetLanguageRepository repo;
        public PresetLanguageService(IPresetLanguageRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<PresetLanguageDTO>> GetAll()
        {            
            throw new NotImplementedException();
        }    
       
        public async Task<PresetLanguageDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(PresetLanguageDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(PresetLanguageDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<PresetLanguageDTO> Map(PresetLanguage obj)
        {
            return new PresetLanguageDTO()
            {
                Id = obj.Id,
                LanguageId = obj.LanguageId,
                NonPlayerId = obj.NonPlayerId,
            };
        }

        public async Task<IEnumerable<PresetLanguageDTO>> GetByNonPlayer(int id)
        {
            List<PresetLanguage> result = (await repo.GetAll()).ToList();
            List<PresetLanguageDTO> dtoList = new List<PresetLanguageDTO>();

            foreach (var obj in result)
            {
                PresetLanguageDTO dto = await Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }
    }
}