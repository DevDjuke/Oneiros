using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPlayerByIdQueryHandler : IRequestHandler<GetPlayerByIdQuery, PlayerDTO>
    {
        private IPlayerService service;

        public GetPlayerByIdQueryHandler(IPlayerService service)
        {
            this.service = service;
        }

        public async Task<PlayerDTO> Handle(GetPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
