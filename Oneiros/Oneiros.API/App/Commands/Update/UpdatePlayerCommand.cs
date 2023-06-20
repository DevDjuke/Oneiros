using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePlayerCommand : IRequest<bool>
    {
        public PlayerDTO Player { get; set; }
    }
}