using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Commands.Delete;
using Oneiros.API.App.Queries.GetAll;
using Oneiros.API.App.Queries.GetById;
using Oneiros.API.Controllers.Base;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CampaignController : BaseController, ICrudController
    {
        public CampaignController(IMediator mediator) : base(mediator) { }

        [HttpGet("all")]
        public async Task<JsonResult> GetAll()
        {
            List<CampaignDTO> result = (await mediator.Send(new GetAllCampaignsQuery())).ToList();
            return new JsonResult(result);
        }

        [HttpGet("detail/{id}")]
        public async Task<JsonResult> Get(int id)
        {
            DTO result = await mediator.Send(new GetCampaignByIdQuery() { Id = id });
            return new JsonResult(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            bool result = (await mediator.Send(new DeleteCampaignCommand() { Id = id }));
            return new StatusCodeResult(result ? 200 : 500);
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
