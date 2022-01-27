using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Data.Model
{
    public class Player
    {
        public int Id { get; set; }
        public int No { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }

        
        public PlayerRace Race { get; set; }
        public PlayerKlasse Klasse { get; set; }
        public PlayerSubGroup SubGroup { get; set; }
        public PlayerFocus Focus { get; set; }
        public PlayerAffinity Affinity { get; set; }
         
        public bool Camouflage { get; set; }
        public int PickPocket { get; set; }

        public string Notes { get; set; }

        public Amulet Amulet { get; set; }
        public BackGround BackGround { get; set; }

        public List<PlayerSkill> Skills { get; set; }
        public List<PlayerItem> Items { get; set; }

        public int Gold { get; set; }
        public int Silver { get; set; }
        public int Copper { get; set; }
    }
}
