using Microsoft.AspNetCore.Mvc;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Controllers
{
    public class PresetController : Controller
    {
        private IPresetWebService webService;

        public PresetController(IPresetWebService webService)
        {
            this.webService = webService;
        }

        public async Task<IActionResult> Index()
        {
            return View(await webService.GetSimplePresetList());
        }
    }
}
