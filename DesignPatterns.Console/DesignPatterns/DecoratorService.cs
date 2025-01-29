using DesignPatterns.Decorators;

namespace DesignPatterns
{
    public static class DecoratorService
    {
        public static void Execute()
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} costs ${coffee.GetCost()}");

            // Add milk to the coffee
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs ${coffee.GetCost()}");

            // Add sugar to the coffee
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} costs ${coffee.GetCost()}");
        }
    }
}