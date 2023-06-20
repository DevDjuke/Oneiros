using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class AbilityControllerController : BaseController, ICrudController
    {
        public AbilityControllerController(IMediator mediator) : base(mediator) { }

        [HttpGet("all")]
        public async Task<JsonResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpGet("detail/{id}")]
        public async Task<JsonResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> Update()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }
    }
}