namespace DataLayer.Entities
{
    public class Shop : IEntity
    {
        public string PointName { get; set; }
        public string Description { get; set; }

        public ICollection<Item> Items { get; set; }
        public Manager? Manager { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
