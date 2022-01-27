using Oneiros.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Infrastructure.Repositories
{
    public interface IPlayerRepository
    {
        Task<Player> GetById(int playerId);
        Task<Player> Add(Player player);
    }
}
