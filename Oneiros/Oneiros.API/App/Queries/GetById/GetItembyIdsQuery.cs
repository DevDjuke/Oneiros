
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetItemByIdQuery : IRequest<ItemDTO>
    {
        public int Id { get; set; }
    }
}