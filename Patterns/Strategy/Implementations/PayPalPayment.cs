using Patterns.Strategy.Iterface;

namespace Patterns.Strategy.Implementations
{
    internal class PayPalPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            // create http client

            // create body for PayPal

            // process api call

            Console.WriteLine($"Processing {amount} via PayPal Card");
        }
    }
}
