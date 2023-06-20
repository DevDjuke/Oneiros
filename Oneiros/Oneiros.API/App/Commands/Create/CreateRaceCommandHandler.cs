using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceCommandHandler : IRequestHandler<CreateRaceCommand, bool>
    {
        private IRaceService service;

        public CreateRaceCommandHandler(IRaceService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateRaceCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Race);
        }
    }
}
