using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data.DTO
{
    [Serializable]
    public class CampaignDTO : DTO
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsDone { get; set; }
        public int NumberOfPlayers { get; set; }

        override public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("CampaignId", CampaignId);
            info.AddValue("CampaignName", CampaignName);
            info.AddValue("IsDone", IsDone);
            info.AddValue("StartDate", StartDate);
            info.AddValue("EndDate", EndDate);
            info.AddValue("NumberOfPlayers", NumberOfPlayers);
        }
    }
}
