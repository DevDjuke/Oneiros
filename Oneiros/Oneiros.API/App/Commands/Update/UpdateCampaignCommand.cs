using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateCampaignCommand : IRequest<bool>
    {
        public CampaignDTO Campaign { get; set; }
    }
}