using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCharacterFeatureCommandHandler : IRequestHandler<CreateCharacterFeatureCommand, bool>
    {
        private ICharacterFeatureService service;

        public CreateCharacterFeatureCommandHandler(ICharacterFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCharacterFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CharacterFeature);
        }
    }
}
