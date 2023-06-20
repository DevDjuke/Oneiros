using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.API.Repositories.Interfaces;
using Oneiros.Data.DTO;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using Oneiros.Domain.Model.CharacterModel.Player;

namespace Oneiros.API.Infrastructure.Services
{
    public class ClasseService : IClasseService
    {
        private IClasseRepository repo;
        public ClasseService(IClasseRepository repo) { this.repo = repo; }

        public async Task<IEnumerable<ClasseDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<ClasseDTO> GetById(int id)
        {
            return await Map(await repo.GetById(id));
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(ClasseDTO obj)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Create(ClasseDTO obj)
        {
            throw new NotImplementedException();
        }

        private async Task<ClasseDTO> Map(Classe obj)
        {
            return new ClasseDTO()
            {
                Id = obj.Id,
                Name = obj.Name
            };
        }
    }
}