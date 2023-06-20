using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetFeatureByIdQueryHandler : IRequestHandler<GetPresetFeatureByIdQuery, PresetFeatureDTO>
    {
        private IPresetFeatureService service;

        public GetPresetFeatureByIdQueryHandler(IPresetFeatureService service)
        {
            this.service = service;
        }

        public async Task<PresetFeatureDTO> Handle(GetPresetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
