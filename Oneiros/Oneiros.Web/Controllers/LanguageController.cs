using Microsoft.AspNetCore.Mvc;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Controllers
{
    public class LanguageController : Controller
    {
        private ILanguageWebService webService;

        public LanguageController(ILanguageWebService webService)
        {
            this.webService = webService;
        }

        public async Task<IActionResult> Index()
        {
            return View("Index", await webService.GetLanguageList());
        }
    }
}
