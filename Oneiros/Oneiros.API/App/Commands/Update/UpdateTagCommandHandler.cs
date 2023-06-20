using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateTagCommandHandler : IRequestHandler<UpdateTagCommand, bool>
    {
        private ITagService service;

        public UpdateTagCommandHandler(ITagService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Tag);
        }
    }
}
