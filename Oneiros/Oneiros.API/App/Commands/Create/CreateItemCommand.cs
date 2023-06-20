using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateItemCommand : IRequest<bool>
    {
        public ItemDTO Item { get; set; }
    }
}