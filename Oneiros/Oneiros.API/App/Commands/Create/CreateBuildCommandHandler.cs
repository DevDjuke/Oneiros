using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateBuildCommandHandler : IRequestHandler<CreateBuildCommand, bool>
    {
        private IBuildService service;

        public CreateBuildCommandHandler(IBuildService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateBuildCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Build);
        }
    }
}
