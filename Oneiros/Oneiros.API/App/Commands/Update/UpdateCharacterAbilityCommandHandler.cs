using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterAbilityCommandHandler : IRequestHandler<UpdateCharacterAbilityCommand, bool>
    {
        private ICharacterAbilityService service;

        public UpdateCharacterAbilityCommandHandler(ICharacterAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CharacterAbility);
        }
    }
}
