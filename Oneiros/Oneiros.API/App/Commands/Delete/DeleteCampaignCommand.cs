using MediatR;

namespace Oneiros.API.App.Commands.Delete
{
    public class DeleteCampaignCommand : IRequest<bool>
    {
        public int Id { get; set; }
    }
}
