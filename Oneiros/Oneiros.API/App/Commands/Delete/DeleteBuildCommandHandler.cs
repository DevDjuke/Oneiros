using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteBuildCommandHandler : IRequestHandler<DeleteBuildCommand, bool>
    {
        private IBuildService service;

        public DeleteBuildCommandHandler(IBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
