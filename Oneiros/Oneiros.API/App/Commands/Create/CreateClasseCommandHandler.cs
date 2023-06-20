using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateClasseCommandHandler : IRequestHandler<CreateClasseCommand, bool>
    {
        private IClasseService service;

        public CreateClasseCommandHandler(IClasseService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateClasseCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Classe);
        }
    }
}
