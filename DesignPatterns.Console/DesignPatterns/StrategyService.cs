using DesignPatterns.Strategies;

namespace DesignPatterns
{
    public static class StrategyService
    {
        public static void Execute()
        {
            {
                var cart = new ShoppingCart();

                // Pay using Credit Card
                cart.SetPaymentStrategy(new CreditCardPayment());
                cart.Checkout(100.00m);

                // Pay using PayPal
                cart.SetPaymentStrategy(new PayPalPayment());
                cart.Checkout(50.00m);
            }
        }
    }
}