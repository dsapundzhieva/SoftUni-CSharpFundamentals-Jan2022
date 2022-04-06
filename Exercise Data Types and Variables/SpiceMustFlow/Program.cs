using System;

namespace SpiceMustFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            const int SpicesConsumed = 26;
            const int dropsBy10 = 10;

            int startingYield = int.Parse(Console.ReadLine());
            int totalAmountOfSpice = 0;
            int days = 0;


            if (startingYield < 100)
            {
                Console.WriteLine($"{days}\n{totalAmountOfSpice}");
            }
            else
            {
                while (startingYield >= 100)
                {
                    days++;
                    totalAmountOfSpice += startingYield - SpicesConsumed;
                    startingYield -= dropsBy10;
                }
                totalAmountOfSpice -= SpicesConsumed;
                Console.WriteLine($"{days}\n{totalAmountOfSpice}");
            }
        }
    }
}
