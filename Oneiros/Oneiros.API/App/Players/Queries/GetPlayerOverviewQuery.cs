using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Players.Queries
{
    public class GetPlayerOverviewQuery : IRequest<IEnumerable<PlayerOverview>>
    {
        public int RoanokeId { get; set; }
    }
}
