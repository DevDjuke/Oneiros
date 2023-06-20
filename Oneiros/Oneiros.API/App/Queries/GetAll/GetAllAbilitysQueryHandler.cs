
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllAbilitysQueryHandler : IRequestHandler<GetAllAbilitysQuery, IEnumerable<AbilityDTO>>
    {
        private IAbilityService service;

        public GetAllAbilitysQueryHandler(IAbilityService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<AbilityDTO>> Handle(GetAllAbilitysQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
