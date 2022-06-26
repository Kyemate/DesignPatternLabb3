using DesignPatternLabb3.WarmDrinks;

namespace DesignPatternLabb3.WarmDrinkFactories;

public class CoffeeFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml coffee in your cup");
        return new Coffee();
    }
}