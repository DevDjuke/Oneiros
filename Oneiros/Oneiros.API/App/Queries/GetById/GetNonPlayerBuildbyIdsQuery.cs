
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetNonPlayerBuildByIdQuery : IRequest<NonPlayerBuildDTO>
    {
        public int Id { get; set; }
    }
}