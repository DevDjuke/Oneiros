using MediatR;
using Microsoft.AspNetCore.Mvc;
using Oneiros.API.App.Players.Commands;
using Oneiros.API.App.Players.Queries;
using Oneiros.Domain.Model;
using Oneiros.Data.DTO;

namespace Oneiros.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        private readonly IMediator mediator;

        public PlayerController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet("/all")]
        public async Task<IEnumerable<PlayerOverview>> GetPlayerOverview()
        {
            return await mediator.Send(new GetPlayerOverviewQuery());
        }

        [HttpPost("/add")]
        public async Task<Player> AddPlayer([FromBody] NewPlayerDTO newPlayer)
        {
            return await mediator.Send(new AddPlayerCommand() { NewPlayer = newPlayer });
        }
    }
}
