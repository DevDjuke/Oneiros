using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterSkillByIdQueryHandler : IRequestHandler<GetCharacterSkillByIdQuery, CharacterSkillDTO>
    {
        private ICharacterSkillService service;

        public GetCharacterSkillByIdQueryHandler(ICharacterSkillService service)
        {
            this.service = service;
        }

        public async Task<CharacterSkillDTO> Handle(GetCharacterSkillByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
