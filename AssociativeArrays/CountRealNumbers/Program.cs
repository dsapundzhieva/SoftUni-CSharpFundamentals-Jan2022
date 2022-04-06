using System;
using System.Collections.Generic;
using System.Linq;

namespace CountRealNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            SortedDictionary<int, int> occrrrences = new SortedDictionary<int, int>();

            foreach (int number in numbers)
            {
                if (occrrrences.ContainsKey(number))
                {
                    occrrrences[number]++;
                }
                else
                {
                    occrrrences.Add(number, 1);
                }
            }

            foreach (var item in occrrrences)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
