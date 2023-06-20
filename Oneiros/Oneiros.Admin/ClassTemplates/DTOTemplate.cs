using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Admin.ClassTemplates
{
    public static class DTOTemplate
    {
        public static string Teplate(string filename)
        {
            return $@"
using System;
using System.Runtime.Serialization;

namespace Oneiros.Data.DTO
{{
    public class {filename}DTO : DTO
    {{
        public int Id {{ get; set; }}

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {{
            throw new NotImplementedException();
        }}
    }}
}}
";
        }
    }
}
