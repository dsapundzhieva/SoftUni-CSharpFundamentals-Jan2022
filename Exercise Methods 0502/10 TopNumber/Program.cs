using System;

namespace _10_TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            const int divisibleNumber = 8;
            const int minOddDigit = 1;
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                if (ValidateSumIsDivisibleByAGivenNumber(i, divisibleNumber) && ValidateMinOddDigitCount(i, minOddDigit))
                {
                    Console.WriteLine(i);
                }
            }
        }


        static bool ValidateSumIsDivisibleByAGivenNumber(int number, int divisibleNumber)
        {
            int digit = number;
            int sum = 0;
            while (digit > 0)
            {
                sum += digit % 10;
                digit /= 10;
            }
            return sum % divisibleNumber == 0;
        }


        static bool ValidateMinOddDigitCount(int number, int minOddDigit)
        {
            var digit = number;
           
            var count = 0;

            while (digit > 0)
            {
                digit %= 10;
                if (digit % 2 != 0)
                {
                    count++;
                }
                digit /= 10;
            }
            return count >= minOddDigit;
        }
}
}
