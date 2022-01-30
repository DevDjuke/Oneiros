using Oneiros.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Repositories
{
    public interface IPlayerCampaignRepository
    {
        Task<IEnumerable<PlayerCampaign>> GeByRoanokeId(int roanokeId);
        Task<IEnumerable<PlayerCampaign>> GeByPlayerId(int playerId);
        Task<int> Add(PlayerCampaign playerRoanoke);
    }
}
