using System;

namespace _10_MultiplyEvensByOddsNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            var oddSum = GetSumOfOddDigits(input);
            var evenSum = GetSumOfEvenDigits(input);
            var sum = GetMultipleOfEvenAndOdds(oddSum, evenSum);

            Console.WriteLine(sum);
        }

        static int GetMultipleOfEvenAndOdds(int evenSum, int oddsum)
        {
            return evenSum * oddsum;
        }

        static int GetSumOfEvenDigits(int input)
        {
            var sum = 0;
            while (input != 0)
            {
                var lastDigit = input;
                lastDigit %= 10;
                input /= 10;

                if (lastDigit % 2 == 0)
                {
                    sum += lastDigit;
                }
            }
            return sum;
        }

        static int GetSumOfOddDigits(int input)
        {
            var sum = 0;
            while (input != 0)
            {
                var lastDigit = input;
                lastDigit %= 10;
                input /= 10;

                if (lastDigit % 2 != 0)
                {
                    sum += lastDigit;
                }

            }
            return sum;
        }
    }
}
