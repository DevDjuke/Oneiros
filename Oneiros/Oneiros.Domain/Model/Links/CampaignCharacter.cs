using Oneiros.Domain.Model.CharacterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model
{
    public class CampaignCharacter
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public int CampaignId { get; set; }

        public virtual Character Character { get; set; }
        public virtual Campaign Campaign { get; set; }
    }
}
