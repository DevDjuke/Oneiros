using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;

namespace Oneiros.API.Repositories
{
    public class PlayerRoanokeRepository : IPlayerRoanokeRepository
    {
        public Task<int> Add(PlayerRoanoke playerRoanoke)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerRoanoke>> GeByPlayerId(int playerId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PlayerRoanoke>> GeByRoanokeId(int roanokeId)
        {
            throw new NotImplementedException();
        }
    }
}
