using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Queries.GetAll;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("race")]
    [Produces("application/json")]
    public class RaceControllerController : BaseController, ICrudController
    {
        public RaceControllerController(IMediator mediator) : base(mediator) { }

        [HttpGet("all")]
        public async Task<JsonResult> GetAll()
        {
            List<RaceDTO> result = (await mediator.Send(new GetAllRacesQuery())).ToList();
            return new JsonResult(result);
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