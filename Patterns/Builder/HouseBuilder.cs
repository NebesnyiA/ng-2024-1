using Patterns.Builder.Interfaces;
using Patterns.Builder.Models;

namespace Patterns.Builder
{
    public class HouseBuilder : IHouseBuilder
    {
        private House _house = new House();

        public IHouseBuilder BuildDoors(int number)
        {
            _house.DoorsNumber = number;

            return this;
        }

        public IHouseBuilder BuildFloors(int number)
        {
            _house.FloorsNum = number;

            return this;
        }

        public IHouseBuilder BuildGarage(bool hasGarage)
        {
            _house.HasGarage = hasGarage;

            return this;
        }

        public IHouseBuilder BuildGarden(bool hasGarden)
        {
            _house.HasGarage = hasGarden;

            return this;
        }

        public IHouseBuilder BuildWindows(int number)
        {
            _house.WindowsNumber = number;

            return this;
        }

        public House BuildHouse()
        {
            // todo: validation

            return _house;
        }
    }
}