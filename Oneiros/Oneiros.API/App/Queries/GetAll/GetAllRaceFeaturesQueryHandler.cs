
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllRaceFeaturesQueryHandler : IRequestHandler<GetAllRaceFeaturesQuery, IEnumerable<RaceFeatureDTO>>
    {
        private IRaceFeatureService service;

        public GetAllRaceFeaturesQueryHandler(IRaceFeatureService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<RaceFeatureDTO>> Handle(GetAllRaceFeaturesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
