using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Services;

public class FoeService : IFoeService
{
    public void GetFoeDamage()
    {
        Console.WriteLine("Foe damage is: something");
    }
    public void GetBowDamage() //it should be extracted as not each foe can have a bow
    {
        throw new NotImplementedException();
    }

}
