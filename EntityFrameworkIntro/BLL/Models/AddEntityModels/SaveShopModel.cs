namespace BLL.Models.AddEntityModels
{
    public class SaveShopModel
    {
        public string PointName { get; set; }
        public string Description { get; set; }

        public ICollection<Guid>? Items { get; set; }
        public Guid? ManagerId { get; set; }
    }
}
