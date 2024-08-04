using Patterns.Factory.Models;

namespace Patterns.Factory.FactoryMethod
{
    public class PlaneCreator : Creator
    {
        public override Vehicle FactoryMethod()
        {
            // some strange logics

            return new Plane { Type = "Plane", Name = "Plane name" };
        }
    }
}