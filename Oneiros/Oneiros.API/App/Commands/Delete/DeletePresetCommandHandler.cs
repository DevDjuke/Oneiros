using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetCommandHandler : IRequestHandler<DeletePresetCommand, bool>
    {
        private IPresetService service;

        public DeletePresetCommandHandler(IPresetService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeletePresetCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
