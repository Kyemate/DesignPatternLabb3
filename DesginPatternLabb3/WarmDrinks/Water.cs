namespace DesignPatternLabb3.WarmDrinks;

internal class Water : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Warm water is served.");
    }
}