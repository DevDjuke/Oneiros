
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharactersQueryHandler : IRequestHandler<GetAllCharactersQuery, IEnumerable<CharacterDTO>>
    {
        private ICharacterService service;

        public GetAllCharactersQueryHandler(ICharacterService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterDTO>> Handle(GetAllCharactersQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
