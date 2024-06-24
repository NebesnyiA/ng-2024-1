using DependencyInversion.Interfaces;

namespace DependencyInversion.Services
{
    public class PickaxeService : IPickaxeService
    {
        public void Dig()
        {
            Console.WriteLine("Busy. Digging right now");
        }
    }
}
