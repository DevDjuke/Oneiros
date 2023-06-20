using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetPresetSkillByIdQueryHandler : IRequestHandler<GetPresetSkillByIdQuery, PresetSkillDTO>
    {
        private IPresetSkillService service;

        public GetPresetSkillByIdQueryHandler(IPresetSkillService service)
        {
            this.service = service;
        }

        public async Task<PresetSkillDTO> Handle(GetPresetSkillByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
