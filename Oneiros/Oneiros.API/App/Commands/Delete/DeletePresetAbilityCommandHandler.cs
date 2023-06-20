using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetAbilityCommandHandler : IRequestHandler<DeletePresetAbilityCommand, bool>
    {
        private IPresetAbilityService service;

        public DeletePresetAbilityCommandHandler(IPresetAbilityService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeletePresetAbilityCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
