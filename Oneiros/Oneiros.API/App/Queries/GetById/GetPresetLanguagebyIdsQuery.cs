
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetLanguageByIdQuery : IRequest<PresetLanguageDTO>
    {
        public int Id { get; set; }
    }
}