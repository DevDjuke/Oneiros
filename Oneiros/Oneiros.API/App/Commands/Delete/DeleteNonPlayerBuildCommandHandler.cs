using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteNonPlayerBuildCommandHandler : IRequestHandler<DeleteNonPlayerBuildCommand, bool>
    {
        private INonPlayerBuildService service;

        public DeleteNonPlayerBuildCommandHandler(INonPlayerBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteNonPlayerBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
