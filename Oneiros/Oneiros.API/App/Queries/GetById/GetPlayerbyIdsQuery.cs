
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPlayerByIdQuery : IRequest<PlayerDTO>
    {
        public int Id { get; set; }
    }
}