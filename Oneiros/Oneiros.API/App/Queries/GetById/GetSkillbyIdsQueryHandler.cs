using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetSkillByIdQueryHandler : IRequestHandler<GetSkillByIdQuery, SkillDTO>
    {
        private ISkillService service;

        public GetSkillByIdQueryHandler(ISkillService service)
        {
            this.service = service;
        }

        public async Task<SkillDTO> Handle(GetSkillByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
