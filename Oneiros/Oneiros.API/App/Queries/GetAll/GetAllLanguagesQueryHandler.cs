
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllLanguagesQueryHandler : IRequestHandler<GetAllLanguagesQuery, IEnumerable<LanguageDTO>>
    {
        private ILanguageService service;

        public GetAllLanguagesQueryHandler(ILanguageService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<LanguageDTO>> Handle(GetAllLanguagesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
