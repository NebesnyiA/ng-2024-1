namespace DataLayer.Entities
{
    public class Manager : IEntity
    {
        public string FullName { get; set; }
        public decimal Salary { get; set; } = 0;

        public Shop Shop { get; set; }
    }
}
