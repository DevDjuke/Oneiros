using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;

using Oneiros.Data.DTO;
using Oneiros.Infrastructure.Services;

namespace Oneiros.API.Infrastructure.Services
{
    public class PlayerService : IPlayerService
    {
        private IPlayerRepository playerRepository;
        private IPlayerCampaignRepository playerCampaignRepository;

        public PlayerService(
            IPlayerRepository playerRepository,
            IPlayerCampaignRepository playerCampaignRepository)
        {
            this.playerRepository = playerRepository;
            this.playerCampaignRepository = playerCampaignRepository;
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

            await playerCampaignRepository.Add(
                new PlayerCampaign()
                {
                    PlayerId = player.Id,
                    RoanokeId = newPlayer.RoanokeId
                });

            return player;
        }
    }
}
