using System;
using System.Collections.Generic;

namespace _04_ListOfProducts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < numberOfProducts; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();

            for (int i = 0; i < numberOfProducts; i++)
            {
                Console.WriteLine($"{i+1}.{products[i]}");
            }
        }
    }
}
