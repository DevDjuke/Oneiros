using Microsoft.AspNetCore.Mvc;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Controllers
{
    public class NPCController : Controller
    {
        private INPCWebService webService;

        public NPCController(INPCWebService webService)
        {
            this.webService = webService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await webService.GetNPCList());
        }

        public async Task<IActionResult> Page()
        {
            return View(await webService.GetNPCList());
        }

        [HttpPost]
        public async Task<IActionResult> Order(string order)
        {
            var npcList = await webService.GetNPCList();
            var model = (npcList, order);
            return PartialView("_NPCList", model);
        }
    }
}
