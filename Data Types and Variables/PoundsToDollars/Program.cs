using System;

namespace PoundsToDollars
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal britishPound = decimal.Parse(Console.ReadLine());
            decimal usDollar = 1.31m;
            decimal britishPoundToUsDollar = britishPound * usDollar;
            Console.WriteLine($"{britishPoundToUsDollar:f3}");
        }
    }
}
