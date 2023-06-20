using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class PresetAbility
    {
        public int Id { get; set; }
        public int PresetId { get; set; }
        public int AbilityId { get; set; }

        public int Score { get; set; }

        public virtual Character Character { get; set; }
        public virtual Preset Preset { get; set; }
    }
}
