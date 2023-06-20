using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetAbilityCommandHandler : IRequestHandler<CreatePresetAbilityCommand, bool>
    {
        private IPresetAbilityService service;

        public CreatePresetAbilityCommandHandler(IPresetAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePresetAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.PresetAbility);
        }
    }
}
