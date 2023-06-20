using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterByIdQueryHandler : IRequestHandler<GetCharacterByIdQuery, CharacterDTO>
    {
        private ICharacterService service;

        public GetCharacterByIdQueryHandler(ICharacterService service)
        {
            this.service = service;
        }

        public async Task<CharacterDTO> Handle(GetCharacterByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
