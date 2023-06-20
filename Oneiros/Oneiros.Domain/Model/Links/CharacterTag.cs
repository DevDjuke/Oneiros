using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class CharacterTag
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int TagId { get; set; }

        public virtual Character Character { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
