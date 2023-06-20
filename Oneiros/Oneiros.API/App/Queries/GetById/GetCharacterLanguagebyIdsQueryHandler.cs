using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetCharacterLanguageByIdQueryHandler : IRequestHandler<GetCharacterLanguageByIdQuery, CharacterLanguageDTO>
    {
        private ICharacterLanguageService service;

        public GetCharacterLanguageByIdQueryHandler(ICharacterLanguageService service)
        {
            this.service = service;
        }

        public async Task<CharacterLanguageDTO> Handle(GetCharacterLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
