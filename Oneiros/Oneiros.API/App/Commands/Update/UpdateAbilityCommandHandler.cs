using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateAbilityCommandHandler : IRequestHandler<UpdateAbilityCommand, bool>
    {
        private IAbilityService service;

        public UpdateAbilityCommandHandler(IAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Ability);
        }
    }
}
