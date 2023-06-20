using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceFeatureCommandHandler : IRequestHandler<CreateRaceFeatureCommand, bool>
    {
        private IRaceFeatureService service;

        public CreateRaceFeatureCommandHandler(IRaceFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateRaceFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.RaceFeature);
        }
    }
}
