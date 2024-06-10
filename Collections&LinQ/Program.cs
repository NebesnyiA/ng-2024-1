using Collections_LinQ.Data;
using Collections_LinQ.Model;
using Collections_LinQ.Model.Dto;

#region basic Collections

// array, has an unchangable size, the most optimized collection
int[] array = new int[10];
int[] arr2 = new int[] { 1, 2, 3 };
var lengh = array.Length;

// List, is dynamic collection
// we can add as much values as we need into it
List<string> listOfMonths = new List<string>()
{
    "January",
    "February",
    "March",
    "April",
    "May",
    "June",
    "July",
    "August",
    "September",
    "October",
    "November",
    "December"
};

// for and foreach loop can be used to pass collections
foreach (var month in listOfMonths) 
{
    Console.WriteLine(month);
}
// or
for (var i = 0; i < listOfMonths.Count; i++) 
{
    Console.WriteLine(listOfMonths[i]);
}
// or foreach as function (not supported for arrays and dictionaries)
listOfMonths.ForEach(x => 
{
    Console.WriteLine(x);
});

// but if we deside to update list during foreach, the exception will be throwed
foreach (var month in listOfMonths)
{
    if (month.Contains("ember")) 
    {
        listOfMonths.Remove(month);
    }
}
// this example is not very logical, it usually occurs with more complex object
// in this case it is better to create new collection an rewrite it

// the last collection is Dictionary
// it's based on key value pair

Dictionary<string, string> d = new Dictionary<string, string>() 
{
    { "key1", "value1" },
    { "key2", "value2" }
};

var val = d["key1"]; // in such a way we can get the value by key
d.Add("key3", "value3"); // it's a way to add new key value pair

#endregion

var storages = DataSource.Storages;

#region  First & Last & FirstOrDefault

// will return the first storage in collection
Storage storage1 = storages.First();

// will return first with number 1, or throw exception id there is no such item
storage1 = storages.First(x => x.Number == 1); 

// will return item or null, if there is no such item
storage1 = storages.FirstOrDefault(x => x.Number == 21);

// will return the last one
storage1 = storages.Last();
// also supports condition and LastOrDefault alternative 

#endregion

#region Where & Any & Count

// this one allows to filter collection by some property, returns collection
IEnumerable<Storage> filteredStorages = storages.Where(x => x.City == "BlackCity");
filteredStorages = storages.Where(x => x.Director.PhoneNumber == "021-03");

// this one checks, is there any elem in collection (supports condition)
bool notEmpty = storages.Any();
bool hasFloodedCityInCollection = storages.Any(x => x.City == "Flooded");

// this one counts amount of elements
int count = storages.Count();
count = storages.Count(x => x.City == "BlackCity");

// also these functions can be combined to create more complex queries
// this one will return a collection of storages, where at least one item has code "FX-12"
filteredStorages = storages.Where(x => x.Items.Any(y => y.Code == "FX-12"));
// this will return only that storages with items
filteredStorages = storages.Where(x => x.Items.Count() > 0);

#endregion

#region Select

// Select function is used to take concrete fields from the collection

// this will return a collection of addresses
var addresses = storages.Select(x => x.Address);
// this will return a collection of Directors
var directors = storages.Select(x => x.Director);

// also can be used to create new objects
IEnumerable<StorageDto> storageCommonInfo = storages.Select(x => new StorageDto { DirectorName = x.Director.FullName, Number = x.Number });

// and can be combined with previous functions
var storageNumbersByWeight = storages
    .Where(x => x.Items.Any(x => x.Weight > 10))
    .Select(x => x.Number);

#endregion