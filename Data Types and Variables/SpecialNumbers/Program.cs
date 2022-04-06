using System;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            for (int i = 1; i <= number; i++)
            {
                int sum = 0;
                int currentNumber = i;

                while (currentNumber != 0)
                {
                    int lastDigit = currentNumber % 10;
                    currentNumber /= 10;
                    sum += lastDigit;
                }
                    bool isSpecial = sum == 5 || sum == 7 || sum == 11;
                    Console.WriteLine($"{i} -> {isSpecial}");
            }
        }
    }
}
