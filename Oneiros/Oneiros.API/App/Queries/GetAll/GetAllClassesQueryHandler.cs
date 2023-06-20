
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllClassesQueryHandler : IRequestHandler<GetAllClassesQuery, IEnumerable<ClasseDTO>>
    {
        private IClasseService service;

        public GetAllClassesQueryHandler(IClasseService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<ClasseDTO>> Handle(GetAllClassesQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
