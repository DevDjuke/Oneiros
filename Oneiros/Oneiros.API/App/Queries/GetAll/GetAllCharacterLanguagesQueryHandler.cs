
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllCharacterLanguagesQueryHandler : IRequestHandler<GetAllCharacterLanguagesQuery, IEnumerable<CharacterLanguageDTO>>
    {
        private ICharacterLanguageService service;

        public GetAllCharacterLanguagesQueryHandler(ICharacterLanguageService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<CharacterLanguageDTO>> Handle(GetAllCharacterLanguagesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
