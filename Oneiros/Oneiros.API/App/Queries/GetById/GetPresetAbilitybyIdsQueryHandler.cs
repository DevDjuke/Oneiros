using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetAbilityByIdQueryHandler : IRequestHandler<GetPresetAbilityByIdQuery, PresetAbilityDTO>
    {
        private IPresetAbilityService service;

        public GetPresetAbilityByIdQueryHandler(IPresetAbilityService service)
        {
            this.service = service;
        }

        public async Task<PresetAbilityDTO> Handle(GetPresetAbilityByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
