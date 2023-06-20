using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCampaignCharacterCommand : IRequest<bool>
    {
        public CampaignCharacterDTO CampaignCharacter { get; set; }
    }
}