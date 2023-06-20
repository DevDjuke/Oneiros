using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Oneiros.API.Controllers.Base
{
    public class BaseController : Controller
    {
        internal readonly IMediator mediator;
        public BaseController(IMediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
