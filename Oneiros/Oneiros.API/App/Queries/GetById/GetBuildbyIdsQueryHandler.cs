using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetBuildByIdQueryHandler : IRequestHandler<GetBuildByIdQuery, BuildDTO>
    {
        private IBuildService service;

        public GetBuildByIdQueryHandler(IBuildService service)
        {
            this.service = service;
        }

        public async Task<BuildDTO> Handle(GetBuildByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
