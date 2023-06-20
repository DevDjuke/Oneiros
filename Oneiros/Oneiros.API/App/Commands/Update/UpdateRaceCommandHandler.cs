using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceCommandHandler : IRequestHandler<UpdateRaceCommand, bool>
    {
        private IRaceService service;

        public UpdateRaceCommandHandler(IRaceService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateRaceCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Race);
        }
    }
}
