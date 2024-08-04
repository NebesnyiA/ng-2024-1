using Patterns.Strategy.Iterface;

namespace Patterns.Strategy.Implementations
{
    public class CreditCardPayment : IPaymentStrategy
    {
        public void ProcessPayment(decimal amount)
        {
            // create bank framework object

            // process payment

            Console.WriteLine($"Processing {amount} via Credit Card");
        }
    }
}