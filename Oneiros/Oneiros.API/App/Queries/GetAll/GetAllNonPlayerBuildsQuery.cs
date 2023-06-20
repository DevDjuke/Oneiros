
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllNonPlayerBuildsQuery : IRequest<IEnumerable<NonPlayerBuildDTO>>
    {
    }
}