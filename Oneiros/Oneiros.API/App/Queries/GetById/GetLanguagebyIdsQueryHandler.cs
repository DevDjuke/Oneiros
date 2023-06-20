using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetLanguageByIdQueryHandler : IRequestHandler<GetLanguageByIdQuery, LanguageDTO>
    {
        private ILanguageService service;

        public GetLanguageByIdQueryHandler(ILanguageService service)
        {
            this.service = service;
        }

        public async Task<LanguageDTO> Handle(GetLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
