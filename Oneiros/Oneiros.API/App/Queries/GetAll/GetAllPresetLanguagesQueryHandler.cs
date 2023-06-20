
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetLanguagesQueryHandler : IRequestHandler<GetAllPresetLanguagesQuery, IEnumerable<PresetLanguageDTO>>
    {
        private IPresetLanguageService service;

        public GetAllPresetLanguagesQueryHandler(IPresetLanguageService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PresetLanguageDTO>> Handle(GetAllPresetLanguagesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
