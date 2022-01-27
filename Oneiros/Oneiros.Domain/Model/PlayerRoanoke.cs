using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model
{
    public class PlayerRoanoke
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int RoanokeId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Campaign Roanoke { get; set; }
    }
}
