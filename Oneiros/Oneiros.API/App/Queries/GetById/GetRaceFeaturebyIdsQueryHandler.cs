using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceFeatureByIdQueryHandler : IRequestHandler<GetRaceFeatureByIdQuery, RaceFeatureDTO>
    {
        private IRaceFeatureService service;

        public GetRaceFeatureByIdQueryHandler(IRaceFeatureService service)
        {
            this.service = service;
        }

        public async Task<RaceFeatureDTO> Handle(GetRaceFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
