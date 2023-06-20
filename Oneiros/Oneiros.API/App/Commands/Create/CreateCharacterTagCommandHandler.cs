using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterTagCommandHandler : IRequestHandler<CreateCharacterTagCommand, bool>
    {
        private ICharacterTagService service;

        public CreateCharacterTagCommandHandler(ICharacterTagService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterTagCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CharacterTag);
        }
    }
}
