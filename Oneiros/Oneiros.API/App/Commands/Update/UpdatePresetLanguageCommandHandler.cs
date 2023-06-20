using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetLanguageCommandHandler : IRequestHandler<UpdatePresetLanguageCommand, bool>
    {
        private IPresetLanguageService service;

        public UpdatePresetLanguageCommandHandler(IPresetLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePresetLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.PresetLanguage);
        }
    }
}
