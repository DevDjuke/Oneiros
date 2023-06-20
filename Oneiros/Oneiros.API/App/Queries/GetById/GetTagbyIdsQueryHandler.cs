using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetById
{
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, TagDTO>
    {
        private ITagService service;

        public GetTagByIdQueryHandler(ITagService service)
        {
            this.service = service;
        }

        public async Task<TagDTO> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            return await service.GetById(request.Id);
        }
    }
}
