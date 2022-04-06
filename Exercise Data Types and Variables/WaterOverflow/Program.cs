using System;

namespace WaterOverflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int capacity = 255;
            short numberOfLines = short.Parse(Console.ReadLine());
            int litresInTank = 0;

            for (int i = 0; i < numberOfLines; i++)
            {
                int litersOfWater = int.Parse(Console.ReadLine());
                if (capacity < litersOfWater)
                {
                    Console.WriteLine("Insufficient capacity!");
                    continue;
                }
                else
                {
                    capacity -= litersOfWater;
                    litresInTank += litersOfWater;
                }
            }
            Console.WriteLine(litresInTank);
        }
    }
}
