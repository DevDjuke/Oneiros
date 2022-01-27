using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;

using Oneiros.Data.DTO;

namespace Oneiros.API.Infrastructure.Services
{
    public class PlayerService
    {
        private IPlayerRepository playerRepository;
        private IPlayerRoanokeRepository playerRoanokeRepository;

        public PlayerService(
            IPlayerRepository playerRepository,
            IPlayerRoanokeRepository playerRoanokeRepository)
        {
            this.playerRepository = playerRepository;
            this.playerRoanokeRepository = playerRoanokeRepository;
        }

        public async Task<Player> AddNewPlayer(NewPlayerDTO newPlayer)
        {
            Player player = await playerRepository.Add(
                new Player()
                {
                    Name = newPlayer.Name,
                    FirstName = newPlayer.FirstName,
                    Number = newPlayer.Number,
                });

            await playerRoanokeRepository.Add(
                new PlayerRoanoke()
                {
                    PlayerId = player.Id,
                    RoanokeId = newPlayer.RoanokeId
                });

            return player;
        }
    }
}
