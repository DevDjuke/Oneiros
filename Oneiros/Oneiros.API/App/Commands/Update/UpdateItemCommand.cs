using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateItemCommand : IRequest<bool>
    {
        public ItemDTO Item { get; set; }
    }
}