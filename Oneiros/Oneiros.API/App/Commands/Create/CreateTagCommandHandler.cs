using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Create
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand, bool>
    {
        private ITagService service;

        public CreateTagCommandHandler(ITagService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            return await service.Create(request.Tag);
        }
    }
}
