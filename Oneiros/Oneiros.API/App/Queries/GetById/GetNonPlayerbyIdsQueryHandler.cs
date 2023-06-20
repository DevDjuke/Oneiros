using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetNonPlayerByIdQueryHandler : IRequestHandler<GetNonPlayerByIdQuery, NonPlayerDTO>
    {
        private INonPlayerService service;

        public GetNonPlayerByIdQueryHandler(INonPlayerService service)
        {
            this.service = service;
        }

        public async Task<NonPlayerDTO> Handle(GetNonPlayerByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
