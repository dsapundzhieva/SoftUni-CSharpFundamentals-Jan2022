using System;

namespace _5._1_BlackFlag
{
    class Program
    {
        static void Main()
        {
            int days = int.Parse(Console.ReadLine());

            int plundersForADay = int.Parse(Console.ReadLine());

            decimal expectedPlunder = decimal.Parse(Console.ReadLine());

            decimal additionalPlunder = plundersForADay / 2.0m;

            decimal totalPlunder = 0;

            for (int i = 1; i <= days; i++)
            {
                totalPlunder += plundersForADay;

                totalPlunder = i % 3 == 0 ? totalPlunder += additionalPlunder : totalPlunder;

                totalPlunder = i % 5 == 0 ? totalPlunder *= 0.7m : totalPlunder;
            }

            if (totalPlunder >= expectedPlunder)
            {
                Console.WriteLine($"Ahoy! {totalPlunder:f2} plunder gained.");
            }
            else
            {
                decimal percentageOfThePlunder = (totalPlunder / expectedPlunder) * 100;
                Console.WriteLine($"Collected only {percentageOfThePlunder:f2}% of the plunder.");
            }
        }
    }
}
