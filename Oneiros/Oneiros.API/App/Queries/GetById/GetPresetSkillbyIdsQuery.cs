
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetSkillByIdQuery : IRequest<PresetSkillDTO>
    {
        public int Id { get; set; }
    }
}