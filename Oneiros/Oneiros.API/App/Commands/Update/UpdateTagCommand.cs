using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateTagCommand : IRequest<bool>
    {
        public TagDTO Tag { get; set; }
    }
}