using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetNonPlayerBuildByIdQueryHandler : IRequestHandler<GetNonPlayerBuildByIdQuery, NonPlayerBuildDTO>
    {
        private INonPlayerBuildService service;

        public GetNonPlayerBuildByIdQueryHandler(INonPlayerBuildService service)
        {
            this.service = service;
        }

        public async Task<NonPlayerBuildDTO> Handle(GetNonPlayerBuildByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
