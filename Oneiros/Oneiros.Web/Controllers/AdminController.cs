using Microsoft.AspNetCore.Mvc;
using Oneiros.Web.Services.Base;

namespace Oneiros.Web.Controllers
{
    public class AdminController : Controller
    {
        private IAdminWebService webService;

        public AdminController(IAdminWebService webService)
        {
            this.webService = webService;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
