using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterAbilityCommandHandler : IRequestHandler<DeleteCharacterAbilityCommand, bool>
    {
        private ICharacterAbilityService service;

        public DeleteCharacterAbilityCommandHandler(ICharacterAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCharacterAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
