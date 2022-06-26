using DesignPatternLabb3.WarmDrinks;

namespace DesignPatternLabb3.WarmDrinkFactories;

public class CappuccinoFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml cappuccino in your cup");
        return new Cappuccino();
    }
}