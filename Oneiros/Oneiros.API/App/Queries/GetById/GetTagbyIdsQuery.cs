
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetTagByIdQuery : IRequest<TagDTO>
    {
        public int Id { get; set; }
    }
}