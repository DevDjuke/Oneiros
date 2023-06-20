using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterAbilityByIdQueryHandler : IRequestHandler<GetCharacterAbilityByIdQuery, CharacterAbilityDTO>
    {
        private ICharacterAbilityService service;

        public GetCharacterAbilityByIdQueryHandler(ICharacterAbilityService service)
        {
            this.service = service;
        }

        public async Task<CharacterAbilityDTO> Handle(GetCharacterAbilityByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
