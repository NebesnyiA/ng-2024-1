using Collections_LinQ.Model;

namespace Collections_LinQ.Data
{
    public static class DataSource
    {
        public static IEnumerable<Storage> Storages { get; set; } = new List<Storage>() 
        {
            new () 
            {
                Number = 1,
                City = "BlackCity",
                Address = "Five Fontaines street 10",
                Director = new ()
                {
                    FullName = "John Anderson",
                    PhoneNumber = "021-03"
                },
                Items = new List<Item>
                {
                    new () { Code = "FX-12", Description = "desc", Weight = 10 },
                    new () { Code = "FX-122", Description = "desc", Weight = 1 },
                    new () { Code = "FX-11", Description = "desc", Weight = 11 },
                    new () { Code = "FX-131", Description = "desc", Weight = 9 }
                }
            },
            new ()
            {
                Number = 23,
                City = "BlackCity",
                Address = "Gambling street 777",
                Director = new ()
                {
                    FullName = "Billy Joe",
                    PhoneNumber = "0212-13"
                },
            },
            new ()
            {
                Number = 88,
                City = "Valley of beer",
                Address = "st. Drunkard 5",
                Director = new ()
                {
                    FullName = "Bob Bottom",
                    PhoneNumber = "021-0123"
                },
            },
            new ()
            {
                Number = 4,
                City = "Flooded",
                Address = "Boatman avenue 10/4",
                Director = new ()
                {
                    FullName = "John Snow",
                    PhoneNumber = "021-22"
                },
            }
        };
    }
}