using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterTagByIdQueryHandler : IRequestHandler<GetCharacterTagByIdQuery, CharacterTagDTO>
    {
        private ICharacterTagService service;

        public GetCharacterTagByIdQueryHandler(ICharacterTagService service)
        {
            this.service = service;
        }

        public async Task<CharacterTagDTO> Handle(GetCharacterTagByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
