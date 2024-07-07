namespace DataLayer.Entities
{
    public class Item : IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Shop Shop { get; set; }
        public Guid ShopId { get; set; }
    }
}
