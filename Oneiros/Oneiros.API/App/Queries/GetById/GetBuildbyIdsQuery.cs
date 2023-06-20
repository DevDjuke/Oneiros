
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetBuildByIdQuery : IRequest<BuildDTO>
    {
        public int Id { get; set; }
    }
}