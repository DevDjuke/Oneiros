using Oneiros.Domain.Model;
using Oneiros.Domain.Model.CharacterModel;
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Oneiros.Data.DTO
{
    public class NonPlayerDTO : DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public RaceDTO Race { get; set; }
        public List<NonPlayerBuildDTO> Builds { get; set; }
        public List<PresetLanguageDTO> Languages { get; set; }
        

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("name", Name);
            info.AddValue("race", Race);
            info.AddValue("builds", Builds);
            info.AddValue("languages", Languages);
        }
    }
}
