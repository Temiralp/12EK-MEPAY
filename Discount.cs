using System;

namespace ComplexScenario
{
    public class Discount
    {
        public double Percentage { get; set; }

        public Discount(double percentage)
        {
            Percentage = percentage;
        }

        public void ApplyDiscount(double originalPrice)
        {
            double discountedPrice = originalPrice - (originalPrice * Percentage / 100);
            Console.WriteLine($"Original price: ${originalPrice}, Discounted price: ${discountedPrice}");
        }
    }
}
