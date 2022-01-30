using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data.DTO
{
    [Serializable]
    public class CampaignDTO : ISerializable
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public bool IsDone { get; set; }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("CampaignId", CampaignId);
            info.AddValue("CampaignName", CampaignName);
            info.AddValue("IsDone", IsDone);
        }
    }
}
