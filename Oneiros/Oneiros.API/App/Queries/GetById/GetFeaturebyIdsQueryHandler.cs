using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetFeatureByIdQueryHandler : IRequestHandler<GetFeatureByIdQuery, FeatureDTO>
    {
        private IFeatureService service;

        public GetFeatureByIdQueryHandler(IFeatureService service)
        {
            this.service = service;
        }

        public async Task<FeatureDTO> Handle(GetFeatureByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
