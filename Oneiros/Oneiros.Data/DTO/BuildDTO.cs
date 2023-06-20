
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using System;
using System.Runtime.Serialization;
using System.Xml.Linq;

namespace Oneiros.Data.DTO
{
    public class BuildDTO : DTO
    {
        public int Id { get; set; }
        public PresetDTO Preset { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("preset", Preset);
        }
    }
}
