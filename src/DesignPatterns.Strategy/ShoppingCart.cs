using DesignPatterns.Strategy;

namespace DesignPatterns.Strategies
{
    public class ShoppingCart
    {
        private IPaymentStrategy _paymentStrategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            _paymentStrategy = paymentStrategy;
        }

        public void Checkout(decimal amount)
        {
            if (_paymentStrategy == null)
            {
                throw new InvalidOperationException("Payment strategy is not set.");
            }
            _paymentStrategy.Pay(amount);
        }
    }
}