using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateLanguageCommandHandler : IRequestHandler<CreateLanguageCommand, bool>
    {
        private ILanguageService service;

        public CreateLanguageCommandHandler(ILanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Language);
        }
    }
}
