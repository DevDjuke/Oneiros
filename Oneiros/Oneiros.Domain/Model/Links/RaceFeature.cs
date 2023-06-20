using Oneiros.Domain.Model.CharacterModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oneiros.Domain.Model.Links
{
    public class RaceFeature
    {
        public int Id { get; set; }
        public int RaceId { get; set; }
        public int FeatureId { get; set; }

        public virtual Race Race { get; set; }
        public virtual Feature Feature { get; set; }
    }
}
