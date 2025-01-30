using DesignPatterns.Strategy;

namespace DesignPatterns.Strategies
{
    public class PayPalPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }
}