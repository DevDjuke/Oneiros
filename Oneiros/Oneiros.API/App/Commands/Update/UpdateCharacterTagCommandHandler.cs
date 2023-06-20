using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterTagCommandHandler : IRequestHandler<UpdateCharacterTagCommand, bool>
    {
        private ICharacterTagService service;

        public UpdateCharacterTagCommandHandler(ICharacterTagService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterTagCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CharacterTag);
        }
    }
}
