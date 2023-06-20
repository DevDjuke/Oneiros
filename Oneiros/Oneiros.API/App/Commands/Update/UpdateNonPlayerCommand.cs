using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateNonPlayerCommand : IRequest<bool>
    {
        public NonPlayerDTO NonPlayer { get; set; }
    }
}