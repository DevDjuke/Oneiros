using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteRaceCommandHandler : IRequestHandler<DeleteRaceCommand, bool>
    {
        private IRaceService service;

        public DeleteRaceCommandHandler(IRaceService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteRaceCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
