
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetFeaturesQueryHandler : IRequestHandler<GetAllPresetFeaturesQuery, IEnumerable<PresetFeatureDTO>>
    {
        private IPresetFeatureService service;

        public GetAllPresetFeaturesQueryHandler(IPresetFeatureService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PresetFeatureDTO>> Handle(GetAllPresetFeaturesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
