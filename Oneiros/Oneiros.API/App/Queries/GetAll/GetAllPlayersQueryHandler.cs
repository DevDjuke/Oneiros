
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPlayersQueryHandler : IRequestHandler<GetAllPlayersQuery, IEnumerable<PlayerDTO>>
    {
        private IPlayerService service;

        public GetAllPlayersQueryHandler(IPlayerService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PlayerDTO>> Handle(GetAllPlayersQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
