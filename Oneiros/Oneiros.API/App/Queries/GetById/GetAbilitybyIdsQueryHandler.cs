using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetAbilityByIdQueryHandler : IRequestHandler<GetAbilityByIdQuery, AbilityDTO>
    {
        private IAbilityService service;

        public GetAbilityByIdQueryHandler(IAbilityService service)
        {
            this.service = service;
        }

        public async Task<AbilityDTO> Handle(GetAbilityByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
