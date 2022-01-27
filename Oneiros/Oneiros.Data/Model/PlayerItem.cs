namespace Oneiros.Data.Model
{
    public class PlayerItem
    {
        public int Id { get; set; }

        public int ItemId { get; set; }
        public int PlayerId { get; set; }

        public int Quantity { get; set; }
        public bool Stackable { get; set; }
        public string Notes { get; set; }

        public virtual Item Item { get; set; }
        public virtual Player Player { get; set; }
    }
}