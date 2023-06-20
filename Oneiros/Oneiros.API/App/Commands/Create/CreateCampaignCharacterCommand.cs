using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCampaignCharacterCommand : IRequest<bool>
    {
        public CampaignCharacterDTO CampaignCharacter { get; set; }
    }
}