using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateRaceAbilityCommandHandler : IRequestHandler<CreateRaceAbilityCommand, bool>
    {
        private IRaceAbilityService service;

        public CreateRaceAbilityCommandHandler(IRaceAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateRaceAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.RaceAbility);
        }
    }
}
