using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterLanguageCommandHandler : IRequestHandler<UpdateCharacterLanguageCommand, bool>
    {
        private ICharacterLanguageService service;

        public UpdateCharacterLanguageCommandHandler(ICharacterLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CharacterLanguage);
        }
    }
}
