using MediatR;
using Oneiros.Domain.Model;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Players.Commands
{
    public class AddPlayerCommand : IRequest<Player>
    {
       public NewPlayerDTO NewPlayer { get; set; }
    }
}
