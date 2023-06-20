
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterAbilitysQueryHandler : IRequestHandler<GetAllCharacterAbilitysQuery, IEnumerable<CharacterAbilityDTO>>
    {
        private ICharacterAbilityService service;

        public GetAllCharacterAbilitysQueryHandler(ICharacterAbilityService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterAbilityDTO>> Handle(GetAllCharacterAbilitysQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
