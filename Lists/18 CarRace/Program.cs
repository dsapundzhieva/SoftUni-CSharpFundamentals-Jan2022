using System;
using System.Collections.Generic;
using System.Linq;

namespace _18_CarRace
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> carRace = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToList();

            List<int> firstCar = carRace.GetRange(0, carRace.Count / 2);
            List<int> secondCar = carRace.GetRange(carRace.Count / 2 + 1, carRace.Count / 2);
            secondCar.Reverse();

            double sumFirst = 0;
            double sumSecond = 0;

            for (int i = 0; i < carRace.Count/2; i++)
            {
                sumFirst += firstCar[i];

                sumSecond += secondCar[i];

                if (firstCar[i] == 0)
                {
                    sumFirst = sumFirst - (sumFirst * 0.20);
                }
                if (secondCar[i] == 0)
                {
                    sumSecond = sumSecond - (sumSecond * 0.20);
                }
            }

            if (sumFirst < sumSecond)
            {
                Console.WriteLine($"The winner is left with total time: {sumFirst}");
            }
            else
            {
                Console.WriteLine($"The winner is right with total time: {sumSecond}");

            }
        }
    }
}
