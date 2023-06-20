using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterFeatureByIdQueryHandler : IRequestHandler<GetCharacterFeatureByIdQuery, CharacterFeatureDTO>
    {
        private ICharacterFeatureService service;

        public GetCharacterFeatureByIdQueryHandler(ICharacterFeatureService service)
        {
            this.service = service;
        }

        public async Task<CharacterFeatureDTO> Handle(GetCharacterFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
