using System;
using System.Linq;

namespace EvenAndOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] %2 ==0)
                {
                    evenSum += array[i];
                }
                else
                {
                    oddSum += array[i];
                }
            }

            var result = evenSum - oddSum;
            Console.WriteLine(result);
        }
    }
}
