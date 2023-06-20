using MediatR;
using Oneiros.API.Infrastructure.Services.Base;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdatePresetCommandHandler : IRequestHandler<UpdatePresetCommand, bool>
    {
        private IPresetService service;

        public UpdatePresetCommandHandler(IPresetService service)
        {
            this.service = service;
        }

        public async Task<bool> Handle(UpdatePresetCommand request, CancellationToken cancellationToken)
        {
            return await service.Update(request.Preset);
        }
    }
}
