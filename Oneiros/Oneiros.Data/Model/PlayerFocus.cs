namespace Oneiros.Data.Model
{
    public class PlayerFocus
    {
        public int Id { get; set; }

        public int PlayerId { get; set; }
        public int FocusId { get; set; }

        public int Niveau { get; set; }

        public virtual Player Player { get; set; }
        public virtual Focus Focus { get; set; }
    }
}