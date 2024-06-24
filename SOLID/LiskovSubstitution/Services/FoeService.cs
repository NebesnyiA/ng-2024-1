using LiskovSubstitution.Interface;
using SingleResponsibility.Models;

namespace LiskovSubstitution.Services;

public class FoeService : IFoeService
{
    public string GetName(Foe foe)
    {
        return foe.Name;
    }
}
