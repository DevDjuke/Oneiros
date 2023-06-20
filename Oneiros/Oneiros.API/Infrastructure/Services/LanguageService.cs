using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;
using System.Collections.Generic;

namespace Oneiros.API.Infrastructure.Services
{
    public class LanguageService : ILanguageService
    {        
        private ILanguageRepository repo;
        public LanguageService(ILanguageRepository repo){this.repo = repo;}
        
        public async Task<IEnumerable<LanguageDTO>> GetAll()
        {          
            List<Language> result = (await repo.GetAll()).ToList();
            List<LanguageDTO> dtoList = new List<LanguageDTO>();

            foreach (var obj in result)
            {
                LanguageDTO dto = Map(obj);
                dtoList.Add(dto);
            }

            return dtoList;
        }    
       
        public async Task<LanguageDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }
        
        public async Task<bool> Update(LanguageDTO obj){
            throw new NotImplementedException();
        }
        
        public async Task<bool> Create(LanguageDTO obj)
        {
            throw new NotImplementedException();
        }

        private LanguageDTO Map(Language obj)
        {
            return new LanguageDTO()
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }
    }
}