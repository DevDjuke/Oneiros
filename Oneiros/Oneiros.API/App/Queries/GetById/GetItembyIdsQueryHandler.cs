using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetItemByIdQueryHandler : IRequestHandler<GetItemByIdQuery, ItemDTO>
    {
        private IItemService service;

        public GetItemByIdQueryHandler(IItemService service)
        {
            this.service = service;
        }

        public async Task<ItemDTO> Handle(GetItemByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
