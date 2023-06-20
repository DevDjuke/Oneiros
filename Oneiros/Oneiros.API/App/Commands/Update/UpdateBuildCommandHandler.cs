using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateBuildCommandHandler : IRequestHandler<UpdateBuildCommand, bool>
    {
        private IBuildService service;

        public UpdateBuildCommandHandler(IBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Build);
        }
    }
}
