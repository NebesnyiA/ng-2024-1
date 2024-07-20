namespace BLL.Models.GetEntityModels
{
    public class ShopReadModel
    {
        public Guid ShopId { get; set; }
        public string PointName { get; set; }
        public string Description { get; set; }

        public List<ItemModel> Items { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
