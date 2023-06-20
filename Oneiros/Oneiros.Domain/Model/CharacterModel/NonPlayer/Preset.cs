using Oneiros.Domain.Model.CharacterModel.Player;
using Oneiros.Domain.Model.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.CharacterModel.NonPlayer
{
    public class Preset
    {
        public  int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }

        public int BaseClassId { get; set; }
        public virtual Classe BaseClass { get; set; }

        public virtual List<PresetAbility> Abilities { get; set; }
        public virtual List<PresetSkill> Skills { get; set; }
        public virtual List<PresetFeature> Features { get; set; }
    }
}
