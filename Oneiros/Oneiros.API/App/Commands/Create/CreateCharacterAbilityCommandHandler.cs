using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterAbilityCommandHandler : IRequestHandler<CreateCharacterAbilityCommand, bool>
    {
        private ICharacterAbilityService service;

        public CreateCharacterAbilityCommandHandler(ICharacterAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CharacterAbility);
        }
    }
}
