using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePresetLanguageCommandHandler : IRequestHandler<CreatePresetLanguageCommand, bool>
    {
        private IPresetLanguageService service;

        public CreatePresetLanguageCommandHandler(IPresetLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreatePresetLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.PresetLanguage);
        }
    }
}
