using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Campaigns.Queries
{
    public class GetAllCampaignsQuery : IRequest<IEnumerable<CampaignDTO>>
    {
    }
}
