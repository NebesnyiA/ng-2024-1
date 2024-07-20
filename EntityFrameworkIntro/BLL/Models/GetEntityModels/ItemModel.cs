namespace BLL.Models.GetEntityModels
{
    public class ItemModel
    {
        public Guid ItemId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Guid ShopId { get; set; }
    }
}
