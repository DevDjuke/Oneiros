using Microsoft.AspNetCore.Mvc;
using Oneiros.Data.DTO;
using Oneiros.Infrastructure.Web;
using Oneiros.Web.Models;

namespace Oneiros.Web.Controllers
{
    public class CampaignController : Controller
    {
        private ICampaignWebService webService;

        public CampaignController(ICampaignWebService webService) 
        {
            this.webService = webService;
        }

        public async Task<IActionResult> Index()
        {
            CampaignViewModel result = new CampaignViewModel()
            {
                Campaigns = (await webService.GetAll())
            };

            return View(result);
        }
    }
}
