
using System;
using System.Runtime.Serialization;

namespace Oneiros.Data.DTO
{
    public class PresetSkillDTO : DTO
    {
        public int Id { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            throw new NotImplementedException();
        }
    }
}
