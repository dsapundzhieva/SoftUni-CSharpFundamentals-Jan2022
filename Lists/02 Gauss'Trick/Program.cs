using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_Gauss_Trick
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = Console.ReadLine()
                           .Split()
                           .Select(double.Parse)
                           .ToList();

            List<double> sumedNum = new List<double>();

            for (int i = 0; i < numbers.Count/2; i++)
            {
                sumedNum.Add(numbers[i] + numbers[numbers.Count - 1 - i]);
               
            }

            if (numbers.Count % 2 != 0)
            {
                sumedNum.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", sumedNum));
        }
    }
}
