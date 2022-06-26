namespace DesignPatternLabb3.WarmDrinks;

public class Coffee : IWarmDrink
{
    public void Consume()
    {
        Console.WriteLine("Coffee is served.");
    }
}