using Microsoft.AspNetCore.Mvc;

namespace Oneiros.API.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PlayerController : Controller
    {
        public PlayerController()
        {

        }

        [HttpGet]
        public IEnumerable<string> GetPlayerOverview()
        {
            return null;
        }
    }
}
