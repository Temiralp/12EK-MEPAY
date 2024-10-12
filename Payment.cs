using System;

namespace ComplexScenario
{
    public class Payment
    {
        public double Amount { get; set; }
        public string Method { get; set; }

        public Payment(double amount, string method)
        {
            Amount = amount;
            Method = method;
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of ${Amount} using {Method}");
        }

        public void ValidatePayment()
        {
            Console.WriteLine("Validating payment method...");  // Added method
        }
    }
}
