using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateLanguageCommandHandler : IRequestHandler<UpdateLanguageCommand, bool>
    {
        private ILanguageService service;

        public UpdateLanguageCommandHandler(ILanguageService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateLanguageCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Language);
        }
    }
}
