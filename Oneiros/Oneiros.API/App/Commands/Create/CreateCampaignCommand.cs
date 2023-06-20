using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateCampaignCommand : IRequest<bool>
    {
        public CampaignDTO Campaign { get; set; }
    }
}