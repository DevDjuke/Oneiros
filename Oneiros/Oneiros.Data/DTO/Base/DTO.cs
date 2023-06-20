using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data.DTO
{
    [Serializable]
    public abstract class DTO : ISerializable
    {
        public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
    }
}
