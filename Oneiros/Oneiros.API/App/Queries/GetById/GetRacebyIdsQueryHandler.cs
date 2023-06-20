using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceByIdQueryHandler : IRequestHandler<GetRaceByIdQuery, RaceDTO>
    {
        private IRaceService service;

        public GetRaceByIdQueryHandler(IRaceService service)
        {
            this.service = service;
        }

        public async Task<RaceDTO> Handle(GetRaceByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
