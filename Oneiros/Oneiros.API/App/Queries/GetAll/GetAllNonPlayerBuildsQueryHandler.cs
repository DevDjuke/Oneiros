
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllNonPlayerBuildsQueryHandler : IRequestHandler<GetAllNonPlayerBuildsQuery, IEnumerable<NonPlayerBuildDTO>>
    {
        private INonPlayerBuildService service;

        public GetAllNonPlayerBuildsQueryHandler(INonPlayerBuildService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<NonPlayerBuildDTO>> Handle(GetAllNonPlayerBuildsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
