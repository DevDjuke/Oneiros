using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetLanguageByIdQueryHandler : IRequestHandler<GetPresetLanguageByIdQuery, PresetLanguageDTO>
    {
        private IPresetLanguageService service;

        public GetPresetLanguageByIdQueryHandler(IPresetLanguageService service)
        {
            this.service = service;
        }

        public async Task<PresetLanguageDTO> Handle(GetPresetLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
