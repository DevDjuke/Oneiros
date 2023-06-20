
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterSkillsQueryHandler : IRequestHandler<GetAllCharacterSkillsQuery, IEnumerable<CharacterSkillDTO>>
    {
        private ICharacterSkillService service;

        public GetAllCharacterSkillsQueryHandler(ICharacterSkillService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterSkillDTO>> Handle(GetAllCharacterSkillsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
