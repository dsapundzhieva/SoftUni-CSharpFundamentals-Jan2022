using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCount = int.Parse(Console.ReadLine());

            double pricePerCapsule;
            double days;
            double capsulesCount;
            double orderPrice=0;
            double total = 0;

            for (int i = 0; i < numberOfCount; i++)
            {
                days = double.Parse(Console.ReadLine());
                capsulesCount = double.Parse(Console.ReadLine());
                pricePerCapsule = double.Parse(Console.ReadLine());

                orderPrice = days * capsulesCount * pricePerCapsule;
                Console.WriteLine($"The price for the coffee is: ${orderPrice:f2}");
                total += orderPrice;
            }
            Console.WriteLine($"Total: ${total:f2}");
        }
    }
}
