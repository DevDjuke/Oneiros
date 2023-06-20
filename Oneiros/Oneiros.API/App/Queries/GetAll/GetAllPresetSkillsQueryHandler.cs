
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllPresetSkillsQueryHandler : IRequestHandler<GetAllPresetSkillsQuery, IEnumerable<PresetSkillDTO>>
    {
        private IPresetSkillService service;

        public GetAllPresetSkillsQueryHandler(IPresetSkillService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<PresetSkillDTO>> Handle(GetAllPresetSkillsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
