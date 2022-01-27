using Oneiros.Domain.Model;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Repositories
{
    public interface IPlayerRoanokeRepository
    {
        Task<IEnumerable<PlayerRoanoke>> GeByRoanokeId(int roanokeId);
        Task<IEnumerable<PlayerRoanoke>> GeByPlayerId(int playerId);
        Task<int> Add(PlayerRoanoke playerRoanoke);
    }
}
