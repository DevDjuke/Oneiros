using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeletePresetLanguageCommandHandler : IRequestHandler<DeletePresetLanguageCommand, bool>
    {
        private IPresetLanguageService service;

        public DeletePresetLanguageCommandHandler(IPresetLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeletePresetLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
