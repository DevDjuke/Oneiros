using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateAbilityCommandHandler : IRequestHandler<CreateAbilityCommand, bool>
    {
        private IAbilityService service;

        public CreateAbilityCommandHandler(IAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Ability);
        }
    }
}
