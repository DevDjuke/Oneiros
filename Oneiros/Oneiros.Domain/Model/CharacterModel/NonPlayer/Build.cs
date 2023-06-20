using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.CharacterModel.NonPlayer
{
    public class Build
    {
        public int Id { get; set; }

        public int PresetId { get; set; }
        public virtual Preset Preset { get; set; }

        public int Tier { get; set; }
    }
}
