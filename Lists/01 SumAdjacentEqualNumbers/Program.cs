﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _01_SumAdjacentEqualNumbers
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

            for (int i = 0; i < numbers.Count-1; i++)
            {
                if (numbers[i] == numbers[i+1])
                {
                    numbers[i] += numbers[i+1];
                    numbers.RemoveAt(i + 1);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}