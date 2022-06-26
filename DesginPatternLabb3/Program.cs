using DesignPatternLabb3.WarmDrinks;

namespace DesignPatternLabb3
{
    class Program
    {
        static void Main(string[] args)
        {
            var machine = new WarmDrinkMachine();
            IWarmDrink drink = machine.MakeDrink();
            drink.Consume();
        }
    }
}