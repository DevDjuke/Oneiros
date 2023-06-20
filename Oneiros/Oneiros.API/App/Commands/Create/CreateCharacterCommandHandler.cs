using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterCommandHandler : IRequestHandler<CreateCharacterCommand, bool>
    {
        private ICharacterService service;

        public CreateCharacterCommandHandler(ICharacterService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Character);
        }
    }
}
