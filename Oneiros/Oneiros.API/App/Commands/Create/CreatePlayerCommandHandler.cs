using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePlayerCommandHandler : IRequestHandler<CreatePlayerCommand, bool>
    {
        private IPlayerService service;

        public CreatePlayerCommandHandler(IPlayerService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePlayerCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Player);
        }
    }
}
