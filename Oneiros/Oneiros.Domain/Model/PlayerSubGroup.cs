using Oneiros.Data.Enums;

namespace Oneiros.Domain.Model
{
    public class PlayerSubGroup
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int SubGroupId { get; set; }

        public SubGroupNiveau Niveau { get; set; }

        public virtual Player Player { get; set; }
        public virtual SubGroup SubGroup { get; set; }
    }
}