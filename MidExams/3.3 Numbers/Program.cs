using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._3_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

            double sum = (double)(numbers.Sum());
            double average = sum / numbers.Count;

            numbers = numbers
                .Where(x => x > average)
                .OrderByDescending(x => x)
                .Take(5)
                .ToList();

            if (numbers.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
