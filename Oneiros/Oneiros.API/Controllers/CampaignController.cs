using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Campaigns.Queries;
using Oneiros.Data.DTO;
using System.Text.Json;

namespace Oneiros.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [Produces("application/json")]
    public class CampaignController : Controller
    {
        private readonly IMediator mediator;

        public CampaignController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("all")]
        public async Task<JsonResult> GetCampaignOverview()
        {
            List<CampaignDTO> result = (await mediator.Send(new GetAllCampaignsQuery())).ToList();
            return new JsonResult(result);
        }
    }
}
