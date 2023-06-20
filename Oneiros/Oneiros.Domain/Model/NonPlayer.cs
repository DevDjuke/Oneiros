using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using Oneiros.Domain.Model.Links;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model
{
    public class NonPlayer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int RaceId { get; set; }

        public virtual Race Race { get; set; }
        public virtual List<NonPlayerBuild> Builds { get; set; }
        public virtual List<PresetLanguage> Languages { get; set; }
    }
}
