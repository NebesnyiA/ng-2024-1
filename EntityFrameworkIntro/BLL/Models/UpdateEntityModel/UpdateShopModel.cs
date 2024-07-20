namespace BLL.Models.UpdateEntityModel
{
    public class UpdateShopModel
    {
        public Guid ShopId { get; set; }
        public string PointName { get; set; }
        public string Description { get; set; }

        public List<Guid> Items { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
