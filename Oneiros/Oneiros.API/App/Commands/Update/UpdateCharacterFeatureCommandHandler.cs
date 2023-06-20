using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCharacterFeatureCommandHandler : IRequestHandler<UpdateCharacterFeatureCommand, bool>
    {
        private ICharacterFeatureService service;

        public UpdateCharacterFeatureCommandHandler(ICharacterFeatureService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCharacterFeatureCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CharacterFeature);
        }
    }
}
