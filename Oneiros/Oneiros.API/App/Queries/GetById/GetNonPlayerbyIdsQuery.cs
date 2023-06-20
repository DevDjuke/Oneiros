
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetNonPlayerByIdQuery : IRequest<NonPlayerDTO>
    {
        public int Id { get; set; }
    }
}