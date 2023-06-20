
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetByIdQuery : IRequest<PresetDTO>
    {
        public int Id { get; set; }
    }
}