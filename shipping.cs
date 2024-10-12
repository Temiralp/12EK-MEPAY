Tusing System;

namespace ComplexScenario
{
    public class Shipping
    {
        public string Address { get; set; }

        public Shipping(string address)
        {
            Address = address;
        }

        public void ShipOrder()
        {
            Console.WriteLine($"Order shipped to {Address}");
        }
    }
}
