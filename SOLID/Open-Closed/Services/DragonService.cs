using Open_Closed.Models;

namespace Open_Closed.Services;

public class DragonService
{
    public string GetDragonType(Dragon dragon)
    {
        var scale = dragon.ScaleColor;
        var flame = dragon.FlameColor;

        var type = "Not flammable dragon";

        if (flame != string.Empty)
        {
            type = scale.ToString() + " Dragon";
        }

        return type;
    }
}
