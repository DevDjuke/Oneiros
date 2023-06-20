using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCampaignCharacterCommandHandler : IRequestHandler<UpdateCampaignCharacterCommand, bool>
    {
        private ICampaignCharacterService service;

        public UpdateCampaignCharacterCommandHandler(ICampaignCharacterService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateCampaignCharacterCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.CampaignCharacter);
        }
    }
}
