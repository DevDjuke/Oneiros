using Microsoft.AspNetCore.Mvc;
using Oneiros.Data.DTO;
using Oneiros.Web.Models;
using Oneiros.Web.Services.Base;

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

            DateTime today = DateTime.Today;
            int daysUntilNextMonday = ((int)DayOfWeek.Monday - (int)today.DayOfWeek + 7) % 7;
            DateTime nextMonday = today.AddDays(daysUntilNextMonday);

            result.CurrentlyRunningCount = result.Campaigns.Count(x => x.IsDone == false);
            result.EndingThisWeekCount = result.Campaigns.Count(x => !x.IsDone && x.EndDate < nextMonday);
            result.StartingThisMonthCount = result.Campaigns.Count(x => x.StartDate.Month == today.Month && x.StartDate > today);

            return View(result);
        }

        [HttpGet("(id)")]
        public async Task<IActionResult> Edit([FromQuery] int id)
        {
            CampaignDTO result = await webService.GetById(id);
            return View(result);
        }
    }
}
