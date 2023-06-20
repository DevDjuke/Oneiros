using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCampaignCharacterCommandHandler : IRequestHandler<CreateCampaignCharacterCommand, bool>
    {
        private ICampaignCharacterService service;

        public CreateCampaignCharacterCommandHandler(ICampaignCharacterService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateCampaignCharacterCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.CampaignCharacter);
        }
    }
}
