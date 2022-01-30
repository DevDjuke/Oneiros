using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;

namespace Oneiros.API.Repositories
{
    public class PlayerCampaignRepository : IPlayerCampaignRepository
    {
        public Task<int> Add(PlayerCampaign playerRoanoke)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerCampaign>> GeByPlayerId(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerCampaign>> GeByRoanokeId(int roanokeId)
        {
            throw new NotImplementedException();
        }
    }
}
