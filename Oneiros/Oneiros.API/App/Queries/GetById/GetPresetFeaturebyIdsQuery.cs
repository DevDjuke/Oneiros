
using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetFeatureByIdQuery : IRequest<PresetFeatureDTO>
    {
        public int Id { get; set; }
    }
}