
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetsQuery : IRequest<IEnumerable<PresetDTO>>
    {
    }
}