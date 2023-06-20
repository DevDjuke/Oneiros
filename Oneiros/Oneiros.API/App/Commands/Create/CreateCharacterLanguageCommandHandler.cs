using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterLanguageCommandHandler : IRequestHandler<CreateCharacterLanguageCommand, bool>
    {
        private ICharacterLanguageService service;

        public CreateCharacterLanguageCommandHandler(ICharacterLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CharacterLanguage);
        }
    }
}
