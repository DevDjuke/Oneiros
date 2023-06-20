
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllBuildsQuery : IRequest<IEnumerable<BuildDTO>>
    {
    }
}