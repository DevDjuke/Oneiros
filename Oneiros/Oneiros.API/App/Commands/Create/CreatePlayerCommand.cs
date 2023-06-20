using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreatePlayerCommand : IRequest<bool>
    {
        public PlayerDTO Player { get; set; }
    }
}