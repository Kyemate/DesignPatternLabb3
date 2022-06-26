using DesignPatternLabb3.WarmDrinks;

namespace DesignPatternLabb3.WarmDrinkFactories;

public interface IWarmDrinkFactory
{
    IWarmDrink Prepare(int total);
}