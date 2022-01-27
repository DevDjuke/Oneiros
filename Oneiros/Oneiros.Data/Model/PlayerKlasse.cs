namespace Oneiros.Data.Model
{
    public class PlayerKlasse
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int KlasseId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Klasse Klasse { get; set; }
    }
}