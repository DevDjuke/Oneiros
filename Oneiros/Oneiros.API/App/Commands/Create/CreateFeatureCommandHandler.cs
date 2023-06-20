using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateFeatureCommandHandler : IRequestHandler<CreateFeatureCommand, bool>
    {
        private IFeatureService service;

        public CreateFeatureCommandHandler(IFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Feature);
        }
    }
}
