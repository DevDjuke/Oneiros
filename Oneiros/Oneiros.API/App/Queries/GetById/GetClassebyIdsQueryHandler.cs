using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetClasseByIdQueryHandler : IRequestHandler<GetClasseByIdQuery, ClasseDTO>
    {
        private IClasseService service;

        public GetClasseByIdQueryHandler(IClasseService service)
        {
            this.service = service;
        }

        public async Task<ClasseDTO> Handle(GetClasseByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
