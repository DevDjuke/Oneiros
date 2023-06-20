using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string BackStory { get; set; }
        public string Gender { get; set; }

        public int BackGroundId { get; set; }
        public int RaceId { get; set; }

        public string Notes { get; set; }

        public virtual List<CharacterAbility> Abilities { get; set; }
        public virtual List<CharacterSkill> Skills { get; set; }
        public virtual List<CharacterFeature> Features { get; set; }
        public virtual List<CharacterLanguage> Languages { get; set; }

        public virtual BackGround BackGround { get; set; }
        public virtual Race Race { get; set; }
    }
}
