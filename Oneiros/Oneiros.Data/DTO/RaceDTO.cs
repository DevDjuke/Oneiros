
using System;
using System.Runtime.Serialization;

namespace Oneiros.Data.DTO
{
    public class RaceDTO : DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("name", Name);
        }
    }
}
