using DesignPatternLabb3;
using DesignPatternLabb3.WarmDrinks;

namespace DesignPatternLabb3.WarmDrinkFactories;

internal class ChocolateFactory : IWarmDrinkFactory
{
    public IWarmDrink Prepare(int total)
    {
        Console.WriteLine($"Pour {total} ml hot chocolate in your cup");
        return new Chocolate();
    }
}