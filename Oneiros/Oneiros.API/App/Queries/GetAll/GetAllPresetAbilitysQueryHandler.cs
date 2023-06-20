
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetAbilitysQueryHandler : IRequestHandler<GetAllPresetAbilitysQuery, IEnumerable<PresetAbilityDTO>>
    {
        private IPresetAbilityService service;

        public GetAllPresetAbilitysQueryHandler(IPresetAbilityService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PresetAbilityDTO>> Handle(GetAllPresetAbilitysQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
