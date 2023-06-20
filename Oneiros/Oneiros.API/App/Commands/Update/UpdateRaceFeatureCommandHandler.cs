using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceFeatureCommandHandler : IRequestHandler<UpdateRaceFeatureCommand, bool>
    {
        private IRaceFeatureService service;

        public UpdateRaceFeatureCommandHandler(IRaceFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateRaceFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.RaceFeature);
        }
    }
}
