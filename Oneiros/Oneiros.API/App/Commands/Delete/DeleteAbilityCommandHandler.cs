using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteAbilityCommandHandler : IRequestHandler<DeleteAbilityCommand, bool>
    {
        private IAbilityService service;

        public DeleteAbilityCommandHandler(IAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
