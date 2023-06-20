
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetsQueryHandler : IRequestHandler<GetAllPresetsQuery, IEnumerable<PresetDTO>>
    {
        private IPresetService service;

        public GetAllPresetsQueryHandler(IPresetService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PresetDTO>> Handle(GetAllPresetsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
