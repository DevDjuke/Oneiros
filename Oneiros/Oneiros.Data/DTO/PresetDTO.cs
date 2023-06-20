
using Oneiros.Domain.Model.CharacterModel.NonPlayer;
using System;
using System.Runtime.Serialization;

namespace Oneiros.Data.DTO
{
    public class PresetDTO : DTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ClasseDTO BaseClass { get; set; }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new ArgumentNullException("info");

            info.AddValue("id", Id);
            info.AddValue("name", Name);
            info.AddValue("description", Description);
            info.AddValue("baseclass", BaseClass);
        }
    }
}
