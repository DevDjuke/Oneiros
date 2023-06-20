
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllNonPlayersQueryHandler : IRequestHandler<GetAllNonPlayersQuery, IEnumerable<NonPlayerDTO>>
    {
        private INonPlayerService service;

        public GetAllNonPlayersQueryHandler(INonPlayerService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<NonPlayerDTO>> Handle(GetAllNonPlayersQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
