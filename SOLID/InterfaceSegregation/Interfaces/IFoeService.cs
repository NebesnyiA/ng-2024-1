namespace InterfaceSegregation.Interfaces;

public interface IFoeService
{
    void GetFoeDamage();

    void GetBowDamage(); //it should be extracted as not each foe can have a bow
}
