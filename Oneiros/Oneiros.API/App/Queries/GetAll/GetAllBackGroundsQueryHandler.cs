
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllBackGroundsQueryHandler : IRequestHandler<GetAllBackGroundsQuery, IEnumerable<BackGroundDTO>>
    {
        private IBackGroundService service;

        public GetAllBackGroundsQueryHandler(IBackGroundService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<BackGroundDTO>> Handle(GetAllBackGroundsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
