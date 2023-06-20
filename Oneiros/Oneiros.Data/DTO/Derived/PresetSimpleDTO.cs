using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data.DTO.Derived
{
    public class PresetSimpleDTO : DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseClass { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("name", Name);
            info.AddValue("baseclass", BaseClass);
        }
    }
}
