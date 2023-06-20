using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateItemCommandHandler : IRequestHandler<CreateItemCommand, bool>
    {
        private IItemService service;

        public CreateItemCommandHandler(IItemService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Item);
        }
    }
}
