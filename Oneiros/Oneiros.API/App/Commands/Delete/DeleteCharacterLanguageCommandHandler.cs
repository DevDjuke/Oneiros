using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCharacterLanguageCommandHandler : IRequestHandler<DeleteCharacterLanguageCommand, bool>
    {
        private ICharacterLanguageService service;

        public DeleteCharacterLanguageCommandHandler(ICharacterLanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(DeleteCharacterLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Delete(request.Id);
        }
    }
}
