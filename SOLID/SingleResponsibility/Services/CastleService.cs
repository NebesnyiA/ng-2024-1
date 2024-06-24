using SingleResponsibility.Models;

namespace SingleResponsibility.Services;

public class CastleService
{
    public void FearFoes(Castle castle)
    {
        Console.WriteLine($" {castle.LocationName} MAKES BOOOOOOO");
    }

    public void RavenFlight() //should be extracted
    {
        Console.WriteLine("The Raven begin to flies");
    }

    public void StartRenovation() //should we extracted
    {
        Console.WriteLine("Renovation has been started");
    }
}
