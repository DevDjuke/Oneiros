
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllRacesQueryHandler : IRequestHandler<GetAllRacesQuery, IEnumerable<RaceDTO>>
    {
        private IRaceService service;

        public GetAllRacesQueryHandler(IRaceService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<RaceDTO>> Handle(GetAllRacesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
