namespace ItemPriceHistoryTracker.Data
{
    public class Item
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Variant { get; set; }
        public double Price { get; set; }
        public string UnitOfMeaure { get; set; }
        public double Quantity { get; set; }
        public string Description { get; set; }
        public DateTime? Created { get; set; }
        public DateTime? Updated { get; set; } = (DateTime.Now);

    }
}
