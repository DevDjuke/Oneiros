using Microsoft.AspNetCore.Mvc;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Controllers
{
    public class RaceController : Controller
    {
        private IRaceWebService webService;

        public RaceController(IRaceWebService webService)
        {
            this.webService = webService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await webService.GetRaceList());
        }
    }
}
