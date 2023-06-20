using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetFeatureCommandHandler : IRequestHandler<UpdatePresetFeatureCommand, bool>
    {
        private IPresetFeatureService service;

        public UpdatePresetFeatureCommandHandler(IPresetFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePresetFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.PresetFeature);
        }
    }
}
