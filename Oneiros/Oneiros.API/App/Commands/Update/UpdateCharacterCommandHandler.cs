using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterCommandHandler : IRequestHandler<UpdateCharacterCommand, bool>
    {
        private ICharacterService service;

        public UpdateCharacterCommandHandler(ICharacterService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Character);
        }
    }
}
