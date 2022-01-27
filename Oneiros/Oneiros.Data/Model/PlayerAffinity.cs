namespace Oneiros.Data.Model
{
    public class PlayerAffinity
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public int AffinityId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Affinity Affinity { get; set; }
    }
}