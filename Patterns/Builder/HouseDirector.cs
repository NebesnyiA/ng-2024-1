using Patterns.Builder.Interfaces;
using Patterns.Builder.Models;
using System.Text;

namespace Patterns.Builder
{
    public class HouseDirector
    {
        private readonly IHouseBuilder _builder;

        public HouseDirector(IHouseBuilder builder)
        {
            _builder = builder;
        }

        public House ConstructSimpleHouse() 
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("sssss sdas");

            builder.Replace("s", "");

            return _builder
                .BuildFloors(1)
                .BuildDoors(1)
                .BuildWindows(4)
                .BuildGarden(true)
                .BuildHouse();
        }

        public House ConstractExpensiveHouse()
        {
            return _builder
                .BuildFloors(2)
                .BuildDoors(3)
                .BuildWindows(12)
                .BuildGarden(true)
                .BuildGarage(true)
                .BuildHouse();
        }
    }
}