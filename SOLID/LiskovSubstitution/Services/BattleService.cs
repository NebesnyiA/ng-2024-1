using LiskovSubstitution.Interface;
using Open_Closed.Models;

namespace LiskovSubstitution.Services;

public class BattleService
{
    private readonly IFoeService _foeService;

    public BattleService(IFoeService foeService)
    {
        _foeService = foeService;
    }

    public void Battle()
    {
        var skeleton = new Skeleton();
        var witch = new Witch();

        _foeService.GetName(skeleton);
        _foeService.GetName(witch);
    }
}
