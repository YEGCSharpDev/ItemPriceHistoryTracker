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
        public string? Created { get; set; }
        public string? Updated { get; set; } = (DateTime.Now).ToString();

    }
}
