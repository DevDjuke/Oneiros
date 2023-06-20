using Oneiros.Domain.Model.Links;
using System.Collections.Generic;

namespace Oneiros.Domain.Model.CharacterModel
{
    public class Race
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual List<RaceAbility> AbilityModifiers { get; set; } 
    }
}