
using System;
using System.Runtime.Serialization;

namespace Oneiros.Data.DTO
{
    
    public class NonPlayerBuildDTO : DTO
    {
        public int Id { get; set; }

        public int NonPlayerId { get; set; }
        public int BuildId { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("nonplayerid", NonPlayerId);
            info.AddValue("buildid", BuildId);
        }
    }
}
