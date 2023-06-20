
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllBuildsQueryHandler : IRequestHandler<GetAllBuildsQuery, IEnumerable<BuildDTO>>
    {
        private IBuildService service;

        public GetAllBuildsQueryHandler(IBuildService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<BuildDTO>> Handle(GetAllBuildsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
