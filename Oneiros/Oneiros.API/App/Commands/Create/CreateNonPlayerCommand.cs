using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateNonPlayerCommand : IRequest<bool>
    {
        public NonPlayerDTO NonPlayer { get; set; }
    }
}