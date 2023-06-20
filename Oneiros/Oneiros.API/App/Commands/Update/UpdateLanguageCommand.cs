using MediatR;
using Oneiros.Data.DTO;

namespace Oneiros.API.App.Commands.Update
{
    public class UpdateLanguageCommand : IRequest<bool>
    {
        public LanguageDTO Language { get; set; }
    }
}