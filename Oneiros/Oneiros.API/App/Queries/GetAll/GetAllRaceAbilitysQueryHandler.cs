
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllRaceAbilitysQueryHandler : IRequestHandler<GetAllRaceAbilitysQuery, IEnumerable<RaceAbilityDTO>>
    {
        private IRaceAbilityService service;

        public GetAllRaceAbilitysQueryHandler(IRaceAbilityService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<RaceAbilityDTO>> Handle(GetAllRaceAbilitysQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
