using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetByIdQueryHandler : IRequestHandler<GetPresetByIdQuery, PresetDTO>
    {
        private IPresetService service;

        public GetPresetByIdQueryHandler(IPresetService service)
        {
            this.service = service;
        }

        public async Task<PresetDTO> Handle(GetPresetByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
