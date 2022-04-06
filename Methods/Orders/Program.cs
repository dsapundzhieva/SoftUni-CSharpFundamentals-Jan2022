using System;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine();
            var quantity = int.Parse(Console.ReadLine());

            Console.WriteLine($"{CalculateOrder(product, quantity):f2}");

        }

        static double CalculateOrder(string typeOfProduct, int quantity)
        {
            double total = 0.00;
            var price = 0.00;
            switch (typeOfProduct)
            {
                case "water":
                    price = 1.00;
                    total = price * quantity;
                    break;
                case "coffee":
                    price = 1.50;
                    total = price * quantity;
                    break;
                case "coke":
                    price = 1.40;
                    total = price * quantity;
                    break;
                case "snacks":
                    price = 2.00;
                    total = price * quantity;
                    break;
                default:
                    break;
            }
            return total;
        }
    }
}
