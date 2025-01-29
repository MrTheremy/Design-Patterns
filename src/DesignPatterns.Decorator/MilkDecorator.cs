namespace DesignPatterns.Decorators
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee)
        {
        }

        public override string GetDescription()
        {
            return coffee.GetDescription() + ", Milk";
        }

        public override double GetCost()
        {
            return coffee.GetCost() + 1.5; // Cost of adding milk
        }
    }
}