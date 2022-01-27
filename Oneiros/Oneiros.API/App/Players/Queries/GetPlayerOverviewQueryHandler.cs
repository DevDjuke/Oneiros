using MediatR;
using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Repositories;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Players.Queries
{
    public class GetPlayerOverviewQueryHandler : IRequestHandler<GetPlayerOverviewQuery, IEnumerable<PlayerOverview>>
    {
        private IPlayerRepository playerRepository;
        private IPlayerRoanokeRepository playerRoanokeRepository;

        public GetPlayerOverviewQueryHandler(
            IPlayerRepository playerRepository,
            IPlayerRoanokeRepository playerRoanokeRepository)
        {
            this.playerRepository = playerRepository;
            this.playerRoanokeRepository = playerRoanokeRepository;
        }

        public async Task<IEnumerable<PlayerOverview>> Handle(GetPlayerOverviewQuery request, CancellationToken cancellationToken)
        {
            List<PlayerOverview> result = new List<PlayerOverview>();

            IEnumerable<PlayerRoanoke> playersByRoanoke = (await playerRoanokeRepository.GeByRoanokeId(request.RoanokeId)).ToList();

            foreach (PlayerRoanoke p in playersByRoanoke)
            {
                Player player = await playerRepository.GetById(p.Id);

                PlayerOverview overview = new PlayerOverview() { };

                result.Add(overview);
            }

            return result;
        }
    }
}
