using Patterns.Builder.Models;

namespace Patterns.Builder.Interfaces
{
    public interface IHouseBuilder
    {
        IHouseBuilder BuildFloors(int number);

        IHouseBuilder BuildWindows(int number);

        IHouseBuilder BuildDoors(int number);

        IHouseBuilder BuildGarden(bool hasGarden);

        IHouseBuilder BuildGarage(bool hasGarage);

        House BuildHouse(); // GetHouse
    }
}