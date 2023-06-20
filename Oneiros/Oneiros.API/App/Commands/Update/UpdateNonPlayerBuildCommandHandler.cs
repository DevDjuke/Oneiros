using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateNonPlayerBuildCommandHandler : IRequestHandler<UpdateNonPlayerBuildCommand, bool>
    {
        private INonPlayerBuildService service;

        public UpdateNonPlayerBuildCommandHandler(INonPlayerBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateNonPlayerBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.NonPlayerBuild);
        }
    }
}
