using Oneiros.Domain.Model.CharacterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class CharacterAbility
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int AbilityId { get; set; }

        public int Score { get; set; }

        public virtual Character Character { get; set; }
        public virtual Ability Ability { get; set; }
    }
}
