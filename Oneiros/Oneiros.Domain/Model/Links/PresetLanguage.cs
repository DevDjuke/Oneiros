using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class PresetLanguage
    {
        public int Id { get; set; }
        public int NonPlayerId { get; set; }
        public int LanguageId { get; set; }

        public virtual NonPlayer NonPlayer { get; set; }
        public virtual Language Language { get; set; }
    }
}
