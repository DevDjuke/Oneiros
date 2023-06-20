
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterTagsQueryHandler : IRequestHandler<GetAllCharacterTagsQuery, IEnumerable<CharacterTagDTO>>
    {
        private ICharacterTagService service;

        public GetAllCharacterTagsQueryHandler(ICharacterTagService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterTagDTO>> Handle(GetAllCharacterTagsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
