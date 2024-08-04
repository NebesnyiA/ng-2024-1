using Patterns.Factory.Models;

namespace Patterns.Factory.FactoryMethod
{
    public class CarCreator : Creator
    {
        public override Vehicle FactoryMethod()
        {
            return new Car
            {
                Type = "Car",
                Name = "Car name"
            };
        }
    }
}