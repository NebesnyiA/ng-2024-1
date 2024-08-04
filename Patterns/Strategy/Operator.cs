using Patterns.Strategy.Iterface;

namespace Patterns.Strategy
{
    public class Director
    {
        private IPaymentStrategy _strategy;

        public Director(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }

        public void ProceedPayment(decimal amount) 
        {
            _strategy.ProcessPayment(amount);
        }

        public void ChangePaymentWay(IPaymentStrategy strategy)
        {
            _strategy = strategy;
        }
    }
}
