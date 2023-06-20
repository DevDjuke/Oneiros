
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterFeaturesQueryHandler : IRequestHandler<GetAllCharacterFeaturesQuery, IEnumerable<CharacterFeatureDTO>>
    {
        private ICharacterFeatureService service;

        public GetAllCharacterFeaturesQueryHandler(ICharacterFeatureService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterFeatureDTO>> Handle(GetAllCharacterFeaturesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
