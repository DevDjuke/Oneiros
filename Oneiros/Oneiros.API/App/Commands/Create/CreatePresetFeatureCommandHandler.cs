using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetFeatureCommandHandler : IRequestHandler<CreatePresetFeatureCommand, bool>
    {
        private IPresetFeatureService service;

        public CreatePresetFeatureCommandHandler(IPresetFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePresetFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.PresetFeature);
        }
    }
}
