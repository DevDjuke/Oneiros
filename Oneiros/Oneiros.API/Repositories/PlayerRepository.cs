using Microsoft.EntityFrameworkCore;
using Oneiros.API.Infrastructure;
using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.API.Repositories
{
    public class PlayerRepository : IPlayerRepository
    {
        private OneirosContext context;

        public PlayerRepository(OneirosContext context)
        {
            this.context = context;
        }

        public async Task<Player> Add(Player player)
        {
            return (await context.Players.AddAsync(player)).Entity;
        }

        public async Task<Player> GetById(int playerId)
        {
            return await context.Players.Where(x => x.Id == playerId).SingleOrDefaultAsync();
        }
    }
}
