using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateRaceAbilityCommandHandler : IRequestHandler<UpdateRaceAbilityCommand, bool>
    {
        private IRaceAbilityService service;

        public UpdateRaceAbilityCommandHandler(IRaceAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateRaceAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.RaceAbility);
        }
    }
}
