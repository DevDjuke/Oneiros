
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllFeaturesQueryHandler : IRequestHandler<GetAllFeaturesQuery, IEnumerable<FeatureDTO>>
    {
        private IFeatureService service;

        public GetAllFeaturesQueryHandler(IFeatureService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<FeatureDTO>> Handle(GetAllFeaturesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
