﻿using System;

namespace SumDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            while (number != 0)
            {
                int cuurentDigit = number;
                cuurentDigit = number % 10;
                number /= 10;
                sum += cuurentDigit;
            }
            Console.WriteLine(sum);
        }
    }
}
