
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetAbilityByIdQuery : IRequest<PresetAbilityDTO>
    {
        public int Id { get; set; }
    }
}