using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using Oneiros.Domain.Model.Generic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class NonPlayerBuild
    {
        public int Id { get; set; }
        public int NonPlayerId { get; set; }
        public int BuildId { get; set; }

        public virtual Build Build { get; set; }
        public virtual NonPlayer NonPlayer { get; set; }
    }
}
