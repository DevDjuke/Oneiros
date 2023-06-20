using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePlayerCommandHandler : IRequestHandler<UpdatePlayerCommand, bool>
    {
        private IPlayerService service;

        public UpdatePlayerCommandHandler(IPlayerService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePlayerCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Player);
        }
    }
}
