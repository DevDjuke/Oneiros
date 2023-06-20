using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.Controllers.Base;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class NonPlayerCharacterController : BaseController, ICrudController
    {
        public NonPlayerCharacterController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public Task<IActionResult> Create()
        {
            throw new NotImplementedException();
        }

        [HttpDelete("{id}")]
        public Task<IActionResult> Delete(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("detail/{id}")]
        public Task<JsonResult> Get(int id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("all")]
        public Task<JsonResult> GetAll()
        {
            throw new NotImplementedException();
        }

        [HttpPut("{id}")]
        public Task<IActionResult> Update()
        {
            throw new NotImplementedException();
        }

        [HttpGet("list")]
        public Task<JsonResult> GetAllSimplified()
        {
            throw new NotImplementedException();
        }
    }
}
