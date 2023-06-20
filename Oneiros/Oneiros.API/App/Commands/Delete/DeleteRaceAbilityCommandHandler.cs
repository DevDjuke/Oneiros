using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteRaceAbilityCommandHandler : IRequestHandler<DeleteRaceAbilityCommand, bool>
    {
        private IRaceAbilityService service;

        public DeleteRaceAbilityCommandHandler(IRaceAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteRaceAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
