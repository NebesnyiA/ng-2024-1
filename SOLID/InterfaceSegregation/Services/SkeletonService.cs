using InterfaceSegregation.Interfaces;

namespace InterfaceSegregation.Service;

public class SkeletonService : ISkeletonService, IArcherFoeService
{
    public void DoSkeletonThings()
    {
        Console.WriteLine("Skeleton things");
    }

    public void GetBowDamage()
    {
        Console.WriteLine("Bow damage is: ");
    }
}
