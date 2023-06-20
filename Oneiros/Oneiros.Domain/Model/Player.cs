using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model
{
    public class Player
    {
        public int Id { get; set; }

        public int CharacterId { get; set; }
        public int ClassId { get; set; }

        public virtual Classe Classe { get; set; }
        public virtual Character Character { get; set; }
    }
}
