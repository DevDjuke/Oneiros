namespace Oneiros.Data.Model
{
    public class PlayerRace
    {
        public int Id { get; set; }
        public int PlayerId { get; set; }
        public int RaceId { get; set; }

        public virtual Player Player { get; set; }
        public virtual Race Race { get; set; }
    }
}