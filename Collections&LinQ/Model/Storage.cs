namespace Collections_LinQ.Model
{
    public class Storage
    {
        public int Number { get; set; }

        public string City { get; set; }

        public string Address { get; set; }

        public Director Director { get; set; }

        public IEnumerable<Item> Items { get; set; }
    }
}