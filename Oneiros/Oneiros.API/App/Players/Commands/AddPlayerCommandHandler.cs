using MediatR;
using Oneiros.Domain.Model;
using Oneiros.Infrastructure.Services;

namespace Oneiros.API.App.Players.Commands
{
    public class AddPlayerCommandHandler : IRequestHandler<AddPlayerCommand, Player>
    {
        private IPlayerService _playerService;

        public AddPlayerCommandHandler(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        public async Task<Player> Handle(AddPlayerCommand command, CancellationToken cancellationToken)
        {
            return await _playerService.AddNewPlayer(command.NewPlayer);
        }
    }
}
