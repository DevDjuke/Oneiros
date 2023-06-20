using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetBackGroundByIdQueryHandler : IRequestHandler<GetBackGroundByIdQuery, BackGroundDTO>
    {
        private IBackGroundService service;

        public GetBackGroundByIdQueryHandler(IBackGroundService service)
        {
            this.service = service;
        }

        public async Task<BackGroundDTO> Handle(GetBackGroundByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
