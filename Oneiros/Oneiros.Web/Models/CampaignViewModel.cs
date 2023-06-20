using Oneiros.Data.DTO;

namespace Oneiros.Web.Models
{
    public class CampaignViewModel
    {
        public int CurrentlyRunningCount { get; set; }
        public int EndingThisWeekCount { get; set; }
        public int StartingThisMonthCount { get; set; }
        public List<CampaignDTO> Campaigns { get; set; }
    }
}
