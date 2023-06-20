using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetRaceAbilityByIdQueryHandler : IRequestHandler<GetRaceAbilityByIdQuery, RaceAbilityDTO>
    {
        private IRaceAbilityService service;

        public GetRaceAbilityByIdQueryHandler(IRaceAbilityService service)
        {
            this.service = service;
        }

        public async Task<RaceAbilityDTO> Handle(GetRaceAbilityByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
