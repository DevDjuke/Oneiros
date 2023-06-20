using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetAbilityCommandHandler : IRequestHandler<UpdatePresetAbilityCommand, bool>
    {
        private IPresetAbilityService service;

        public UpdatePresetAbilityCommandHandler(IPresetAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePresetAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.PresetAbility);
        }
    }
}
