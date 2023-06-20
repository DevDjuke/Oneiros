
using MediatR;
using Oneiros.API.Infrastructure.Services.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Queries.GetAll
{
    public class GetAllTagsQueryHandler : IRequestHandler<GetAllTagsQuery, IEnumerable<TagDTO>>
    {
        private ITagService service;

        public GetAllTagsQueryHandler(ITagService service)
        {
            this.service = service;
        }

        public async Task<IEnumerable<TagDTO>> Handle(GetAllTagsQuery request, CancellationToken cancellationToken)
        {
            return (await service.GetAll()).ToList();
        }
    }
}
