using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateTagCommand : IRequest<bool>
    {
        public TagDTO Tag { get; set; }
    }
}