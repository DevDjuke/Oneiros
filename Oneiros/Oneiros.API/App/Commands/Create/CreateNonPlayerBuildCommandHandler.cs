using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateNonPlayerBuildCommandHandler : IRequestHandler<CreateNonPlayerBuildCommand, bool>
    {
        private INonPlayerBuildService service;

        public CreateNonPlayerBuildCommandHandler(INonPlayerBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateNonPlayerBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.NonPlayerBuild);
        }
    }
}
